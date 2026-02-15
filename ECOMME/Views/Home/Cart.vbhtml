@Code
    ' Définition du titre de la page et du Layout parent
    ViewData("Title") = "My Shopping Bag - Leader Store"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<link href="https://fonts.googleapis.com/css2?family=Plus+Jakarta+Sans:wght@300;400;600;800&display=swap" rel="stylesheet">
<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/sweetalert2@11/dist/sweetalert2.min.css">
<script src="https://cdn.jsdelivr.net/npm/sweetalert2@11"></script>

<style>
    /* Force black background on main container */
    .cart-main-container {
        background-color: #000000 !important;
        min-height: 100vh;
        padding-top: 60px;
    }

    /* SECTION 1 : Style Global - Noir Absolu */
    .cart-section {
        padding: 60px 0 100px;
        min-height: 90vh;
        background-color: #000000;
    }

    /* SECTION 2 : Cartes et Tableaux (Design Minimaliste) */
    .cart-card {
        background: #080808;
        border: 1px solid #1a1a1a;
        border-radius: 30px;
        overflow: hidden;
        transition: 0.3s;
    }

    .table {
        color: #fff !important;
        margin-bottom: 0;
        vertical-align: middle;
    }

        .table thead th {
            background: #0c0c0c;
            border: none;
            padding: 20px;
            text-transform: uppercase;
            font-size: 11px;
            letter-spacing: 2px;
            color: #47b2e4;
        }

        .table tbody td {
            padding: 25px 20px;
            border-bottom: 1px solid #111;
        }

    /* SECTION 3 : Image de produit dans la table */
    .cart-img-wrapper img {
        width: 80px;
        height: 80px;
        object-fit: cover;
        border-radius: 15px;
        border: 1px solid #222;
    }

    /* SECTION 4 : Résumé de Commande (Summary Box) */
    .summary-box {
        background: #080808;
        border: 1px solid #1a1a1a;
        border-radius: 30px;
        padding: 40px;
        position: sticky;
        top: 100px;
    }

    .summary-item {
        display: flex;
        justify-content: space-between;
        margin-bottom: 15px;
        color: #888;
    }

    /* SECTION 5 : Boutons d'action */
    .btn-checkout {
        background: #fff;
        color: #000;
        border: none;
        padding: 18px;
        border-radius: 100px;
        font-weight: 800;
        width: 100%;
        margin-top: 20px;
        transition: 0.4s;
    }

        .btn-checkout:hover {
            background: #47b2e4;
            color: #fff;
            transform: translateY(-5px);
        }

    .btn-whatsapp {
        background: #25d366;
        color: #fff;
        border-radius: 100px;
        padding: 15px;
        width: 100%;
        margin-top: 15px;
        display: flex;
        align-items: center;
        justify-content: center;
        text-decoration: none;
        font-weight: 700;
    }

        .btn-whatsapp:hover {
            background: #1fa855;
            color: #fff;
        }

    .btn-remove {
        background: #1a1a1a;
        color: #ff4d4d;
        border: none;
        width: 40px;
        height: 40px;
        border-radius: 12px;
        transition: 0.3s;
    }

        .btn-remove:hover {
            background: #ff4d4d;
            color: #fff;
        }

    /* Animation de suppression */
    .fade-out {
        opacity: 0;
        transform: scale(0.9);
        transition: 0.5s;
    }

    /* ========== NEW ADDED FEATURES ========== */

    /* Breadcrumb Navigation */
    .cart-breadcrumb {
        background: #0a0a0a;
        padding: 30px 0;
        border-bottom: 1px solid #1a1a1a;
        margin-bottom: 40px;
    }

    .breadcrumb {
        margin-bottom: 0;
        background: transparent;
        padding: 0;
    }

    .breadcrumb-item {
        color: #666;
        font-size: 0.9rem;
    }

        .breadcrumb-item.active {
            color: #47b2e4;
            font-weight: 600;
        }

        .breadcrumb-item + .breadcrumb-item::before {
            color: #444;
            content: ">";
        }

        .breadcrumb-item a {
            color: #888;
            text-decoration: none;
            transition: 0.3s;
        }

            .breadcrumb-item a:hover {
                color: #47b2e4;
            }

    /* Progress Steps */
    .checkout-steps {
        display: flex;
        justify-content: space-between;
        margin-bottom: 60px;
        padding: 0 40px;
        position: relative;
    }

        .checkout-steps::before {
            content: '';
            position: absolute;
            top: 20px;
            left: 10%;
            right: 10%;
            height: 2px;
            background: #1a1a1a;
            z-index: 0;
        }

    .step-item {
        display: flex;
        flex-direction: column;
        align-items: center;
        position: relative;
        z-index: 1;
    }

    .step-circle {
        width: 40px;
        height: 40px;
        border-radius: 50%;
        background: #1a1a1a;
        border: 2px solid #1a1a1a;
        display: flex;
        align-items: center;
        justify-content: center;
        font-weight: 700;
        margin-bottom: 10px;
        transition: 0.3s;
        color: #666;
    }

    .step-item.active .step-circle {
        background: #47b2e4;
        border-color: #47b2e4;
        color: white;
        box-shadow: 0 0 20px rgba(71, 178, 228, 0.5);
    }

    .step-item.completed .step-circle {
        background: #25d366;
        border-color: #25d366;
        color: white;
    }

    .step-label {
        color: #666;
        font-size: 0.85rem;
        text-align: center;
    }

    .step-item.active .step-label {
        color: #47b2e4;
        font-weight: 600;
    }

    /* Quantity Controls */
    .quantity-controls {
        display: flex;
        align-items: center;
        gap: 10px;
        background: #0a0a0a;
        border: 1px solid #1a1a1a;
        border-radius: 30px;
        padding: 5px;
        width: fit-content;
    }

    .qty-btn {
        background: transparent;
        border: none;
        color: #47b2e4;
        width: 30px;
        height: 30px;
        border-radius: 50%;
        cursor: pointer;
        transition: 0.3s;
        font-size: 1.2rem;
        display: flex;
        align-items: center;
        justify-content: center;
    }

        .qty-btn:hover {
            background: #47b2e4;
            color: white;
        }

    .qty-display {
        min-width: 40px;
        text-align: center;
        font-weight: 700;
        color: white;
    }

    /* Promo Code Section */
    .promo-section {
        background: #0a0a0a;
        border: 1px solid #1a1a1a;
        border-radius: 20px;
        padding: 25px;
        margin-bottom: 25px;
    }

    .promo-input-wrapper {
        display: flex;
        gap: 10px;
    }

    .promo-input {
        flex: 1;
        background: #080808;
        border: 1px solid #1a1a1a;
        border-radius: 30px;
        padding: 12px 20px;
        color: white;
        outline: none;
        transition: 0.3s;
    }

        .promo-input:focus {
            border-color: #47b2e4;
        }

    .btn-apply-promo {
        background: #47b2e4;
        color: white;
        border: none;
        padding: 12px 30px;
        border-radius: 30px;
        font-weight: 700;
        cursor: pointer;
        transition: 0.3s;
    }

        .btn-apply-promo:hover {
            background: #2d8fc7;
        }

    /* Security Badges */
    .security-badges {
        display: flex;
        justify-content: center;
        gap: 20px;
        margin-top: 30px;
        padding-top: 30px;
        border-top: 1px solid #1a1a1a;
    }

    .security-badge {
        display: flex;
        align-items: center;
        gap: 8px;
        color: #888;
        font-size: 0.85rem;
    }

        .security-badge i {
            color: #47b2e4;
            font-size: 1.2rem;
        }

    /* Recommended Products */
    .recommended-section {
        margin-top: 80px;
        padding-top: 60px;
        border-top: 1px solid #1a1a1a;
    }

    .recommended-title {
        font-size: 2rem;
        font-weight: 800;
        text-align: center;
        background: linear-gradient(to right, #ffffff, #47b2e4);
        -webkit-background-clip: text;
        -webkit-text-fill-color: transparent;
        margin-bottom: 40px;
    }

    .recommended-grid {
        display: grid;
        grid-template-columns: repeat(auto-fit, minmax(200px, 1fr));
        gap: 25px;
    }

    .recommended-card {
        background: #0a0a0a;
        border: 1px solid #1a1a1a;
        border-radius: 20px;
        padding: 20px;
        transition: 0.3s;
        cursor: pointer;
        text-align: center;
    }

        .recommended-card:hover {
            transform: translateY(-8px);
            border-color: #47b2e4;
            box-shadow: 0 10px 30px rgba(71, 178, 228, 0.2);
        }

        .recommended-card img {
            width: 100%;
            aspect-ratio: 1/1;
            object-fit: cover;
            border-radius: 15px;
            margin-bottom: 15px;
        }

        .recommended-card h6 {
            font-size: 0.95rem;
            font-weight: 700;
            color: white;
            margin-bottom: 10px;
        }

        .recommended-card .price {
            color: #47b2e4;
            font-size: 1.2rem;
            font-weight: 800;
        }

    /* Empty Cart State */
    .empty-cart-state {
        text-align: center;
        padding: 80px 20px;
    }

    .empty-cart-icon {
        font-size: 5rem;
        color: #1a1a1a;
        margin-bottom: 30px;
    }

    .empty-cart-title {
        font-size: 2rem;
        font-weight: 800;
        color: white;
        margin-bottom: 15px;
    }

    .empty-cart-text {
        color: #888;
        font-size: 1.1rem;
        margin-bottom: 30px;
    }

    .btn-continue-shopping {
        background: #47b2e4;
        color: white;
        border: none;
        padding: 15px 40px;
        border-radius: 50px;
        font-weight: 700;
        text-decoration: none;
        display: inline-block;
        transition: 0.3s;
    }

        .btn-continue-shopping:hover {
            background: #2d8fc7;
            transform: translateY(-3px);
            color: white;
        }

    /* Savings Badge */
    .savings-badge {
        background: linear-gradient(135deg, #25d366, #1fa855);
        color: white;
        padding: 8px 16px;
        border-radius: 20px;
        font-size: 0.85rem;
        font-weight: 700;
        display: inline-block;
        margin-bottom: 15px;
    }

    /* Payment Methods Icons */
    .payment-methods {
        display: flex;
        justify-content: center;
        gap: 15px;
        margin-top: 25px;
        flex-wrap: wrap;
    }

    .payment-icon {
        background: #0a0a0a;
        border: 1px solid #1a1a1a;
        border-radius: 10px;
        padding: 10px 15px;
        color: #888;
        font-size: 0.85rem;
        display: flex;
        align-items: center;
        gap: 8px;
    }

        .payment-icon i {
            font-size: 1.2rem;
        }

    /* Continue Shopping Button */
    .btn-continue {
        background: transparent;
        color: #47b2e4;
        border: 2px solid #47b2e4;
        padding: 12px 30px;
        border-radius: 50px;
        font-weight: 700;
        text-decoration: none;
        display: inline-flex;
        align-items: center;
        gap: 10px;
        transition: 0.3s;
        margin-bottom: 40px;
    }

        .btn-continue:hover {
            background: #47b2e4;
            color: white;
        }

    /* Page Headers */
    .cart-page-header h2 {
        color: #ffffff;
        font-family: 'Plus Jakarta Sans', sans-serif;
    }

    .cart-page-header p {
        color: #888;
    }

    /* Responsive */
    @@media (max-width: 768px) {
        .checkout-steps {
            padding: 0 10px;
        }

        .step-label {
            font-size: 0.7rem;
        }

        .step-circle {
            width: 35px;
            height: 35px;
            font-size: 0.85rem;
        }

        .recommended-grid {
            grid-template-columns: repeat(auto-fit, minmax(150px, 1fr));
            gap: 15px;
        }

        .security-badges {
            flex-direction: column;
            align-items: center;
        }

        .payment-methods {
            flex-direction: column;
        }
    }
</style>

<div class="cart-main-container">
    <!-- ========== NEW: BREADCRUMB ========== -->
    <div class="cart-breadcrumb">
        <div class="container">
            <nav aria-label="breadcrumb">
                <ol class="breadcrumb">
                    <li class="breadcrumb-item"><a href="/">Home</a></li>
                    <li class="breadcrumb-item"><a href="/Home/Index">Shop</a></li>
                    <li class="breadcrumb-item active">Shopping Cart</li>
                </ol>
            </nav>
        </div>
    </div>

    <section class="cart-section">
        <div class="container" data-aos="fade-up">

            <!-- ========== NEW: CONTINUE SHOPPING BUTTON ========== -->
            <a href="/Home/Index" class="btn-continue">
                <i class="bi bi-arrow-left"></i>
                Continue Shopping
            </a>

            <div class="mb-5 cart-page-header">
                <h2 class="fw-800" style="font-size: 2.5rem;">Shopping <span style="color: #47b2e4;">Bag.</span></h2>
                <p class="text-muted">Vous avez <span id="header-count" class="text-white fw-bold">0</span> articles dans votre panier.</p>
            </div>

            <!-- ========== NEW: CHECKOUT STEPS ========== -->
            <div class="checkout-steps">
                <div class="step-item active">
                    <div class="step-circle">
                        <i class="bi bi-bag-check"></i>
                    </div>
                    <div class="step-label">Shopping Cart</div>
                </div>
                <div class="step-item">
                    <div class="step-circle">2</div>
                    <div class="step-label">Checkout</div>
                </div>
                <div class="step-item">
                    <div class="step-circle">3</div>
                    <div class="step-label">Payment</div>
                </div>
                <div class="step-item">
                    <div class="step-circle">4</div>
                    <div class="step-label">Confirmation</div>
                </div>
            </div>

            <div class="row">
                <div class="col-lg-8">
                    <div class="cart-card">
                        <div class="table-responsive">
                            <table class="table">
                                <thead>
                                    <tr>
                                        <th>Produit</th>
                                        <th>Détails</th>
                                        <th>Quantité</th>
                                        <th>Prix</th>
                                        <th class="text-center">Action</th>
                                    </tr>
                                </thead>
                                <tbody id="cart-items-list">
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>

                <div class="col-lg-4">
                    <!-- ========== NEW: PROMO CODE ========== -->
                    <div class="promo-section">
                        <h6 class="fw-bold mb-3" style="color: white;">Have a Promo Code?</h6>
                        <div class="promo-input-wrapper">
                            <input type="text" class="promo-input" id="promoCode" placeholder="Enter code">
                            <button class="btn-apply-promo" onclick="applyPromoCode()">Apply</button>
                        </div>
                    </div>

                    <!-- ========== YOUR ORIGINAL SUMMARY BOX (ENHANCED) ========== -->
                    <div class="summary-box">
                        <h4 class="fw-bold mb-4" style="color: white;">Résumé</h4>

                        <div class="summary-item">
                            <span>Sous-total</span>
                            <span id="subtotal" class="text-white">$0.00</span>
                        </div>
                        <div class="summary-item">
                            <span>Livraison</span>
                            <span class="text-success fw-bold">GRATUIT</span>
                        </div>
                        <div class="summary-item" id="discount-row" style="display: none;">
                            <span>Discount</span>
                            <span id="discount-amount" class="text-success">-$0.00</span>
                        </div>
                        <hr style="border-color: #222; margin: 25px 0;">
                        <div class="d-flex justify-content-between align-items-center mb-4">
                            <span class="fs-5" style="color: white;">Total</span>
                            <strong class="fs-3 text-white" id="cart-total">$0.00</strong>
                        </div>

                        <!-- ========== NEW: SAVINGS BADGE ========== -->
                        <div id="savings-badge-container" style="display: none;">
                            <div class="savings-badge text-center w-100">
                                🎉 You're saving <span id="savings-amount">$0</span>!
                            </div>
                        </div>

                        <button class="btn-checkout" onclick="processOrder()">
                            PAYER MAINTENANT
                        </button>

                        <a href="#" id="whatsapp-link" target="_blank" class="btn-whatsapp">
                            COMMANDER VIA WHATSAPP <i class="bi bi-whatsapp ms-2"></i>
                        </a>

                        <!-- ========== NEW: PAYMENT METHODS ========== -->
                        <div class="payment-methods">
                            <div class="payment-icon">
                                <i class="bi bi-credit-card"></i>
                                <span>Cards</span>
                            </div>
                            <div class="payment-icon">
                                <i class="bi bi-paypal"></i>
                                <span>PayPal</span>
                            </div>
                            <div class="payment-icon">
                                <i class="bi bi-apple"></i>
                                <span>Apple Pay</span>
                            </div>
                        </div>

                        <!-- ========== NEW: SECURITY BADGES ========== -->
                        <div class="security-badges">
                            <div class="security-badge">
                                <i class="bi bi-shield-check"></i>
                                <span>Secure Payment</span>
                            </div>
                            <div class="security-badge">
                                <i class="bi bi-truck"></i>
                                <span>Free Shipping</span>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <!-- ========== NEW: RECOMMENDED PRODUCTS ========== -->
            <div class="recommended-section">
                <h3 class="recommended-title">You May Also Like</h3>
                <div class="recommended-grid" id="recommendedProducts">
                    <!-- Will be populated by JavaScript -->
                </div>
            </div>
        </div>
    </section>
</div>

<script>
    /**
     * ========== YOUR ORIGINAL JAVASCRIPT (ENHANCED) ==========
     */

    document.addEventListener('DOMContentLoaded', function () {
        renderCart();
        loadRecommendedProducts();
    });

    /**
     * 1. Rendu dynamique du panier (ENHANCED WITH QUANTITY)
     */
    function renderCart() {
        let cart = JSON.parse(localStorage.getItem('userCart')) || [];
        const container = document.getElementById('cart-items-list');
        const totalLabel = document.getElementById('cart-total');
        const subtotalLabel = document.getElementById('subtotal');
        const headerCount = document.getElementById('header-count');

        container.innerHTML = '';
        let total = 0;

        if (cart.length === 0) {
            container.innerHTML = `
                <tr>
                    <td colspan="5">
                        <div class="empty-cart-state">
                            <div class="empty-cart-icon">
                                <i class="bi bi-bag-x"></i>
                            </div>
                            <h3 class="empty-cart-title">Your cart is empty</h3>
                            <p class="empty-cart-text">Looks like you haven't added anything to your cart yet</p>
                            <a href="/Home/Index" class="btn-continue-shopping">Start Shopping</a>
                        </div>
                    </td>
                </tr>`;
            document.getElementById('whatsapp-link').style.display = 'none';
        } else {
            document.getElementById('whatsapp-link').style.display = 'flex';
            cart.forEach((item, index) => {
                let priceNum = parseFloat(item.price.replace('$', '')) || 0;
                let quantity = item.quantity || 1;
                let itemTotal = priceNum * quantity;
                total += itemTotal;

                container.innerHTML += `
                    <tr id="item-${index}">
                        <td>
                            <div class="cart-img-wrapper">
                                <img src="${item.img}" alt="Product">
                            </div>
                        </td>
                        <td>
                            <h6 class="mb-0 fw-bold">${item.title}</h6>
                            <small class="text-muted">ID: #${item.id}</small>
                        </td>
                        <td>
                            <div class="quantity-controls">
                                <button class="qty-btn" onclick="updateQuantity(${index}, -1)">
                                    <i class="bi bi-dash"></i>
                                </button>
                                <span class="qty-display" id="qty-${index}">${quantity}</span>
                                <button class="qty-btn" onclick="updateQuantity(${index}, 1)">
                                    <i class="bi bi-plus"></i>
                                </button>
                            </div>
                        </td>
                        <td><span class="fw-bold">$${itemTotal.toFixed(2)}</span></td>
                        <td class="text-center">
                            <button class="btn-remove" onclick="confirmRemove(${index})">
                                <i class="bi bi-trash3"></i>
                            </button>
                        </td>
                    </tr>`;
            });
        }

        let formattedTotal = '$' + total.toFixed(2);
        totalLabel.innerText = formattedTotal;
        subtotalLabel.innerText = formattedTotal;
        headerCount.innerText = cart.length;

        updateWhatsAppLink(cart, formattedTotal);
    }

    /**
     * NEW: Update quantity
     */
    function updateQuantity(index, change) {
        let cart = JSON.parse(localStorage.getItem('userCart')) || [];
        if (!cart[index].quantity) cart[index].quantity = 1;

        cart[index].quantity += change;

        if (cart[index].quantity < 1) cart[index].quantity = 1;
        if (cart[index].quantity > 10) cart[index].quantity = 10;

        localStorage.setItem('userCart', JSON.stringify(cart));
        renderCart();
    }

    /**
     * 2. Confirmation de suppression avec SweetAlert2 (UNCHANGED)
     */
    function confirmRemove(index) {
        Swal.fire({
            title: 'Supprimer cet article ?',
            text: "L'article sera retiré de votre sac.",
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#ff4d4d',
            cancelButtonColor: '#1a1a1a',
            confirmButtonText: 'Oui, supprimer',
            background: '#080808',
            color: '#fff'
        }).then((result) => {
            if (result.isConfirmed) removeFromCart(index);
        });
    }

    /**
     * 3. Suppression logique et animation (UNCHANGED)
     */
    function removeFromCart(index) {
        let cart = JSON.parse(localStorage.getItem('userCart')) || [];
        const row = document.getElementById(`item-${index}`);
        row.classList.add('fade-out');

        setTimeout(() => {
            cart.splice(index, 1);
            localStorage.setItem('userCart', JSON.stringify(cart));
            renderCart();
        }, 400);
    }

    /**
     * 4. Génération automatique du message WhatsApp (ENHANCED)
     */
    function updateWhatsAppLink(cart, total) {
        let message = "*NOUVELLE COMMANDE - LEADER STORE*\n\n";
        cart.forEach((item, i) => {
            let qty = item.quantity || 1;
            message += `🔹 ${item.title} x${qty} (${item.price})\n`;
        });
        message += `\n*TOTAL À PAYER : ${total}*\n\nVeuillez confirmer ma commande.`;

        const encodedMessage = encodeURIComponent(message);
        document.getElementById('whatsapp-link').href = `https://wa.me/212772265286?text=${encodedMessage}`;
    }

    /**
     * 5. Simulation de paiement (UNCHANGED)
     */
    function processOrder() {
        Swal.fire({
            title: 'Traitement en cours...',
            timer: 2000,
            background: '#080808',
            color: '#fff',
            didOpen: () => { Swal.showLoading(); }
        }).then(() => {
            Swal.fire({
                icon: 'success',
                title: 'Commande validée !',
                text: 'Merci pour votre confiance.',
                background: '#080808',
                color: '#fff'
            });
            localStorage.removeItem('userCart');
            renderCart();
        });
    }

    /**
     * ========== NEW JAVASCRIPT FUNCTIONS ==========
     */

    /**
     * Apply Promo Code
     */
    function applyPromoCode() {
        const code = document.getElementById('promoCode').value.trim().toUpperCase();
        const validCodes = {
            'SAVE10': 10,
            'SAVE20': 20,
            'WELCOME': 15
        };

        if (validCodes[code]) {
            const discount = validCodes[code];
            Swal.fire({
                icon: 'success',
                title: `Promo Code Applied!`,
                text: `You got ${discount}% off!`,
                background: '#080808',
                color: '#fff',
                confirmButtonColor: '#47b2e4'
            });

            // Show discount in summary
            document.getElementById('discount-row').style.display = 'flex';
            const subtotal = parseFloat(document.getElementById('subtotal').textContent.replace('$', ''));
            const discountAmount = (subtotal * discount / 100).toFixed(2);
            document.getElementById('discount-amount').textContent = `-$${discountAmount}`;

            const newTotal = (subtotal - discountAmount).toFixed(2);
            document.getElementById('cart-total').textContent = `$${newTotal}`;

            // Show savings badge
            document.getElementById('savings-badge-container').style.display = 'block';
            document.getElementById('savings-amount').textContent = `$${discountAmount}`;
        } else {
            Swal.fire({
                icon: 'error',
                title: 'Invalid Code',
                text: 'Please check your promo code and try again',
                background: '#080808',
                color: '#fff',
                confirmButtonColor: '#ff4d4d'
            });
        }
    }

    /**
     * Load Recommended Products
     */
    function loadRecommendedProducts() {
        const products = [
            { id: 1, name: 'Premium Watch', price: '$299', img: 'https://via.placeholder.com/200x200/0a0a0a/47b2e4?text=Watch' },
            { id: 2, name: 'Designer Bag', price: '$499', img: 'https://via.placeholder.com/200x200/0a0a0a/47b2e4?text=Bag' },
            { id: 3, name: 'Luxury Shoes', price: '$399', img: 'https://via.placeholder.com/200x200/0a0a0a/47b2e4?text=Shoes' },
            { id: 4, name: 'Sunglasses', price: '$199', img: 'https://via.placeholder.com/200x200/0a0a0a/47b2e4?text=Glasses' }
        ];

        const container = document.getElementById('recommendedProducts');
        container.innerHTML = '';

        products.forEach(product => {
            container.innerHTML += `
                <div class="recommended-card">
                    <img src="${product.img}" alt="${product.name}">
                    <h6>${product.name}</h6>
                    <div class="price">${product.price}</div>
                </div>
            `;
        });
    }
</script>
