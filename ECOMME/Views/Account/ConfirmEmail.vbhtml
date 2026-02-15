@Code
    ViewBag.Title = "Confirmer l'e-mail"
End Code

<main aria-labelledby="title">
    <h2 id="title">@ViewBag.Title.</h2>
    <div>
        <p>
            Merci d'avoir confirmé votre e-mail. Veuillez @Html.ActionLink("cliquer ici pour vous connecter", "Login", "Account", routeValues:=Nothing, htmlAttributes:=New With {Key .id = "loginLink"})
        </p>
    </div>
</main>
