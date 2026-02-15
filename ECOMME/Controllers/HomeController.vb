Imports System.Web.Mvc
Imports System.Data.Entity ' Nécessaire pour utiliser .Include() (Eager Loading)
Imports ECOMME ' Namespace de ton projet

Public Class HomeController
    Inherits Controller

    ' Initialisation du contexte de base de données (Entity Framework)
    Private db As New LeadersEntities()

    ' 1. ACTION : INDEX (Page d'accueil)
    ' Affiche la liste de tous les produits disponibles
    Function Index() As ActionResult
        Try
            ' Récupération de tous les produits de la table Product
            Dim products = db.Product.ToList()
            Return View(products)
        Catch ex As Exception
            ' Gestion d'erreur si la connexion à la base de données échoue
            Return Content("Erreur de base de données : " & ex.Message)
        End Try
    End Function

    ' 2. ACTION : CATEGORY
    ' Affiche les différentes catégories de produits (Men, Women, etc.)
    Function Category() As ActionResult
        Try
            ' Récupération de la liste des catégories
            Dim categories = db.Category.ToList()
            Return View(categories)
        Catch ex As Exception
            ' Retourne une liste vide en cas d'erreur pour éviter le crash de la vue
            Return View(New List(Of Category)())
        End Try
    End Function

    ' 3. ACTION : CART (Panier)
    ' Affiche les articles du panier pour l'utilisateur actuel
    Public Function Cart() As ActionResult
        Try
            ' .Include("Product") permet de charger les détails du produit lié à chaque ligne du panier
            ' Ici, l'ID utilisateur est fixé à 1 pour l'exemple (statique)
            Dim myCart = db.Cart.Include("Product").Where(Function(c) c.Userid = 1).ToList()
            Return View(myCart)
        Catch ex As Exception
            Return View(New List(Of Cart)())
        End Try
    End Function

    ' 4. ACTION : ADD TO CART (POST)
    ' Ajoute un produit dans la base de données via une requête AJAX
    <HttpPost>
    Public Function AddToCartDatabase(productId As Integer) As JsonResult
        Try
            ' Création d'une nouvelle instance d'objet Cart (Panier)
            Dim item As New Cart With {
                .Productid = productId,
                .Userid = 1, ' Utilisateur par défaut
                .Qty = 1
            }

            ' Ajout à la table et sauvegarde des changements
            db.Cart.Add(item)
            db.SaveChanges()

            ' Retourne un succès au format JSON pour le script client
            Return Json(New With {.success = True, .message = "Produit ajouté avec succès !"})
        Catch ex As Exception
            ' Retourne l'erreur au format JSON
            Return Json(New With {.success = False, .message = ex.Message})
        End Try
    End Function

    ' 5. ACTIONS : PAGES STATIQUES
    Function About() As ActionResult
        ViewData("Message") = "À propos de notre boutique."
        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Page de contact."
        Return View()
    End Function

    ' NETTOYAGE : Libère les ressources de la base de données
    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing Then
            db.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

End Class