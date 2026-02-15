@ModelType ExternalLoginConfirmationViewModel
@Code
    ViewBag.Title = "S'inscrire"
End Code

<main aria-labelledby="title">
    <h2 id="title">@ViewBag.Title.</h2>
    <h3>Associer votre compte @ViewBag.LoginProvider.</h3>

    @Using Html.BeginForm("ExternalLoginConfirmation", "Account", New With { .ReturnUrl = ViewBag.ReturnUrl }, FormMethod.Post, New With {.role = "form"})
        @Html.AntiForgeryToken()

        @<text>
        <h4>Formulaire d'association</h4>
        <hr />
        @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
        <p class="text-info">
            Vous avez été authentifié avec succès avec <strong>@ViewBag.LoginProvider</strong>.
        Veuillez entrer ci-dessous un nom d’utilisateur pour ce site et cliquer sur le bouton S’inscrire pour valider la
        connexion.
        </p>
        <div class="row">
            @Html.LabelFor(Function(m) m.Email, New With {.class = "col-md-2 col-form-label"})
            <div class="col-md-10">
                @Html.TextBoxFor(Function(m) m.Email, New With {.class = "form-control"})
                        @Html.ValidationMessageFor(Function(m) m.Email, "", New With {.class = "text-danger"})
            </div>
        </div>
        <div class="row">
            <div class="offset-md-2 col-md-10">
                <input type="submit" class="btn btn-outline-dark" value="S'inscrire" />
            </div>
        </div>
        </text>
    End Using
</main>

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
