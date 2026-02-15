@ModelType SetPasswordViewModel
@Code
    ViewBag.Title = "Créer le mot de passe"
End Code

<main aria-labelledby="title">
    <h2 id="title">@ViewBag.Title.</h2>
    <p class="text-info">
        Vous n’avez aucun nom d’utilisateur/mot de passe local pour ce site. Ajoutez un compte local
    pour pouvoir vous connecter sans connexion externe.
    </p>

    @Using Html.BeginForm("SetPassword", "Manage", FormMethod.Post, New With { .role = "form" })
        @Html.AntiForgeryToken()
        @<text>
        <h4>Créer une connexion locale</h4>
        <hr />
        @Html.ValidationSummary("", New With { .class = "text-danger" })
        <div class="row">
            @Html.LabelFor(Function(m) m.NewPassword, New With {.class = "col-md-2 col-form-label"})
            <div class="col-md-10">
                @Html.PasswordFor(Function(m) m.NewPassword, New With {.class = "form-control"})
            </div>
        </div>
        <div class="row">
            @Html.LabelFor(Function(m) m.ConfirmPassword, New With { .class = "col-md-2 col-form-label" })
            <div class="col-md-10">
                @Html.PasswordFor(Function(m) m.ConfirmPassword, New With { .class = "form-control" })
            </div>
        </div>
        <div class="row">
            <div class="offset-md-2 col-md-10">
                <input type="submit" value="Définir le mot de passe" class="btn btn-outline-dark" />
            </div>
        </div>
        </text>
    End Using
</main>

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section