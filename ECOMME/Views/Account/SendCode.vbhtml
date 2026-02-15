@ModelType SendCodeViewModel
@Code
    ViewBag.Title = "Envoyer"
End Code

<main aria-labelledby="title">
    <h2 id="title">@ViewBag.Title.</h2>

    @Using Html.BeginForm("SendCode", "Account", New With { .ReturnUrl = Model.ReturnUrl }, FormMethod.Post, New With { .role = "form" })
        @Html.AntiForgeryToken()
        @Html.Hidden("rememberMe", Model.RememberMe)
        @<text>
        <h4>Envoyer le code de vérification</h4>
        <hr />
        <div class="row">
            <div class="col-md-8">
                Sélectionner le fournisseur d’authentification à deux facteurs :
                @Html.DropDownListFor(Function(model) model.SelectedProvider, Model.Providers)
                <input type="submit" value="Envoyer" class="btn btn-outline-dark" />
            </div>
        </div>
        </text>
    End Using
</main>

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
