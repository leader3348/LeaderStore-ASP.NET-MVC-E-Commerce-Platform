@ModelType IEnumerable(Of ECOMME.Category)
@Code
    ' Définition du titre de la page et liaison avec le Layout principal
    ViewData("Title") = "Departments - Leader Store"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<style>
    /* SECTION 1 : Configuration de la mise en page (Layout) */
    .categories-section {
        background-color: #0b0b0b;
        padding: 140px 0 100px 0;
        color: #fff;
        min-height: 100vh;
    }

    /* SECTION 2 : Design des cartes de catégorie (Style Premium) */
    .category-card {
        background: linear-gradient(145deg, #151515, #1a1a1a);
        border: 1px solid #222;
        border-radius: 30px;
        padding: 50px 30px;
        transition: all 0.5s cubic-bezier(0.4, 0, 0.2, 1);
        text-align: center;
        position: relative;
        overflow: hidden;
        z-index: 1;
    }

        /* Effet de lueur (Glow Effect) au survol */
        .category-card::before {
            content: "";
            position: absolute;
            top: -50%;
            left: -50%;
            width: 200%;
            height: 200%;
            background: radial-gradient(circle, rgba(71, 178, 228, 0.05) 0%, transparent 70%);
            transition: 0.5s;
            z-index: -1;
            opacity: 0;
        }

        .category-card:hover {
            border-color: #47b2e4;
            transform: translateY(-15px); /* Animation de soulèvement */
            box-shadow: 0 20px 40px rgba(0, 0, 0, 0.6);
        }

            .category-card:hover::before {
                opacity: 1;
            }

    /* SECTION 3 : Iconographie dynamique */
    .category-icon {
        font-size: 50px;
        color: #47b2e4;
        margin-bottom: 25px;
        display: inline-block;
        transition: 0.4s;
        background: rgba(71, 178, 228, 0.1);
        width: 100px;
        height: 100px;
        line-height: 100px;
        border-radius: 50%;
    }

    /* SECTION 4 : Barre des caractéristiques (Feature Bar) */
    .feature-bar {
        background: rgba(255,255,255,0.02);
        border: 1px solid #222;
        border-radius: 25px;
        padding: 40px;
        margin-top: 80px;
        backdrop-filter: blur(10px); /* Effet de flou derrière le conteneur */
    }
</style>

<main class="main categories-section">
    <div class="container">

        <div class="text-center mb-5" data-aos="fade-up">
            <span style="color: #47b2e4; letter-spacing: 4px; font-weight: 600; text-transform: uppercase;">Discover our universe</span>
            <h2 class="mt-2" style="font-weight: 900; font-size: 45px;">SHOP BY <span style="color: #47b2e4;">DEPARTMENT</span></h2>
        </div>

        <div class="row gy-5">
            @If Model IsNot Nothing Then
                @For Each item In Model
                    @Code
                        ' Logique métier côté client : Attribution d'icônes selon le nom de la catégorie
                        Dim icon = "bi bi-layers"
                        Dim lowerName = item.Name.ToLower()
                        If lowerName.Contains("men") Then
                            icon = "bi bi-gender-male"
                        ElseIf lowerName.Contains("women") Then
                            icon = "bi bi-gender-female"
                        ElseIf lowerName.Contains("access") Then
                            icon = "bi bi-watch"
                        End If
                    End Code

                    ' Rendu de chaque colonne de catégorie
                    @<div class="col-lg-4 col-md-6" data-aos="fade-up">
                        <div class="category-card">
                            <div class="category-icon">
                                <i class="@icon"></i>
                            </div>
                            <h4>@item.Name</h4>
                            <p>@item.description</p>
                            <a href="@Url.Action("Index", "Home")#portfolio" class="btn-view">
                                EXPLORE COLLECTION <i class="bi bi-arrow-right ms-2"></i>
                            </a>
                        </div>
                    </div>
                Next
            Else
                ' Message d'erreur si la base de données est vide
                @<div class="col-12 text-center py-5">
                    <p class="text-muted">No categories were found in our database.</p>
                </div>
            End If
        </div>

        <div class="feature-bar shadow-lg" data-aos="fade-up">
            <div class="row text-center gy-4">
                <div class="col-md-4">
                    <i class="bi bi-patch-check-fill text-primary fs-3"></i>
                    <h6>AUTHENTICITY</h6>
                </div>
                <div class="col-md-4">
                    <i class="bi bi-lightning-charge-fill text-primary fs-3"></i>
                    <h6>EXPRESS DELIVERY</h6>
                </div>
                <div class="col-md-4">
                    <i class="bi bi-shield-check text-primary fs-3"></i>
                    <h6>SECURE PAYMENT</h6>
                </div>
            </div>
        </div>
    </div>
</main>