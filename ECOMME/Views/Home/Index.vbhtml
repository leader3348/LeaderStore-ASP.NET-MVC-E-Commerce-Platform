@ModelType IEnumerable(Of ECOMME.Product)

@Code       ' Définition du titre de la page transmis au Layout principal
    ViewData("Title") = "Home Page - Leader Store"
End Code

<link href="https://fonts.googleapis.com/css2?family=Plus+Jakarta+Sans:wght@300;400;600;800&display=swap" rel="stylesheet">
<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/sweetalert2@11/dist/sweetalert2.min.css">
<script src="https://cdn.jsdelivr.net/npm/sweetalert2@11"></script>

<style>
    /* ==========   STYLES ========== */
    /* SECTION 1 : Design Global - Mode Sombre Profond (True Black) */
    body {
        font-family: 'Plus Jakarta Sans', sans-serif;
        background-color: #000000 !important;
        color: #ffffff;
    }

    .portfolio {
        background-color: #000000 !important;
        padding: 80px 0;
    }

    /* SECTION 2 : En-tête avec dégradé de texte (Gradient Text) */
    .collection-header h2 {
        font-size: 3.5rem;
        font-weight: 800;
        text-align: center;
        background: linear-gradient(to right, #ffffff, #47b2e4);
        -webkit-background-clip: text;
        -webkit-text-fill-color: transparent;
        margin-bottom: 50px;
    }

    /* SECTION 3 : Système de Filtrage Isotope (UX Moderne) */
    .portfolio-filters {
        list-style: none;
        display: flex;
        justify-content: center;
        gap: 15px;
        margin-bottom: 60px;
    }

        .portfolio-filters li {
            padding: 12px 30px;
            background: #111;
            border-radius: 50px;
            cursor: pointer;
            transition: 0.4s cubic-bezier(0.4, 0, 0.2, 1);
            font-weight: 600;
            border: 1px solid #222;
            color: #888;
        }

            .portfolio-filters li:hover, .portfolio-filters li.filter-active {
                background: #47b2e4;
                color: white;
                border-color: #47b2e4;
                box-shadow: 0 10px 20px rgba(71, 178, 228, 0.3);
            }

    /* SECTION 4 : Cartes Produits (Glassmorphism & Elevating Effect) */
    .product-card {
        background: #0a0a0a;
        border-radius: 25px;
        padding: 15px;
        border: 1px solid #1a1a1a;
        transition: all 0.5s ease;
    }

        .product-card:hover {
            transform: translateY(-15px);
            border-color: #47b2e4;
            box-shadow: 0 20px 40px rgba(0,0,0,0.8);
        }

    .img-container {
        border-radius: 20px;
        overflow: hidden;
        position: relative;
    }

        .img-container img {
            width: 100%;
            aspect-ratio: 1/1;
            object-fit: cover;
            transition: transform 0.8s ease;
        }

    .product-card:hover img {
        transform: scale(1.1);
    }

    /* SECTION 5 : Fenêtre Modale (Quick View) Style Premium */
    .modal-content {
        background-color: #080808 !important;
        border: 1px solid #333 !important;
        border-radius: 40px !important;
        color: white;
    }

    .modal-description {
        color: #aaaaaa;
        font-size: 1.1rem;
        line-height: 1.8;
        font-weight: 300;
        margin: 25px 0;
    }

    .modal-price {
        font-size: 2rem;
        font-weight: 700;
        color: #47b2e4;
    }

    .btn-add-bag {
        background: #47b2e4;
        color: white;
        border: none;
        padding: 20px;
        border-radius: 100px;
        width: 100%;
        font-weight: 800;
        text-transform: uppercase;
        letter-spacing: 1px;
        transition: 0.3s;
    }

        .btn-add-bag:hover {
            background: #fff;
            color: #000;
            transform: scale(1.02);
        }

    /* ========== NEW ADDED FEATURES ========== */

    /* Hero Banner Section */
    .hero-banner {
        background: linear-gradient(135deg, #000000 0%, #1a1a1a 100%);
        padding: 100px 0 80px;
        position: relative;
        overflow: hidden;
        margin-bottom: 60px;
    }

        .hero-banner::before {
            content: '';
            position: absolute;
            top: -50%;
            right: -10%;
            width: 600px;
            height: 600px;
            background: radial-gradient(circle, rgba(71, 178, 228, 0.1) 0%, transparent 70%);
            border-radius: 50%;
            animation: heroFloat 6s ease-in-out infinite;
        }

    @@keyframes heroFloat {
        0%, 100% {
            transform: translateY(0) scale(1);
        }

        50% {
            transform: translateY(-30px) scale(1.1);
        }
    }

    .hero-content {
        position: relative;
        z-index: 2;
    }

    .hero-title {
        font-size: 4.5rem;
        font-weight: 800;
        background: linear-gradient(to right, #ffffff, #47b2e4, #ffffff);
        -webkit-background-clip: text;
        -webkit-text-fill-color: transparent;
        margin-bottom: 20px;
        animation: slideInLeft 0.8s ease-out;
    }

    @@keyframes slideInLeft {
        from {
            opacity: 0;
            transform: translateX(-50px);
        }

        to {
            opacity: 1;
            transform: translateX(0);
        }
    }

    .hero-subtitle {
        font-size: 1.4rem;
        color: #aaa;
        margin-bottom: 30px;
        animation: slideInRight 0.8s ease-out;
    }

    @@keyframes slideInRight {
        from {
            opacity: 0;
            transform: translateX(50px);
        }

        to {
            opacity: 1;
            transform: translateX(0);
        }
    }

    .hero-cta {
        display: inline-flex;
        gap: 20px;
        animation: fadeInUp 1s ease-out;
    }

    @@keyframes fadeInUp {
        from {
            opacity: 0;
            transform: translateY(30px);
        }

        to {
            opacity: 1;
            transform: translateY(0);
        }
    }

    .btn-primary-cta {
        background: linear-gradient(135deg, #47b2e4, #2d8fc7);
        color: white;
        padding: 18px 45px;
        border-radius: 50px;
        font-weight: 700;
        text-decoration: none;
        transition: all 0.3s;
        border: 2px solid #47b2e4;
    }

        .btn-primary-cta:hover {
            transform: translateY(-3px);
            box-shadow: 0 15px 30px rgba(71, 178, 228, 0.4);
            color: white;
        }

    .btn-secondary-cta {
        background: transparent;
        color: white;
        padding: 18px 45px;
        border-radius: 50px;
        font-weight: 700;
        text-decoration: none;
        transition: all 0.3s;
        border: 2px solid #47b2e4;
    }

        .btn-secondary-cta:hover {
            background: #47b2e4;
            color: white;
            transform: translateY(-3px);
        }

    /* Search Bar */
    .search-section {
        background: #0a0a0a;
        padding: 40px 0;
        border-bottom: 1px solid #222;
    }

    .search-bar-container {
        max-width: 800px;
        margin: 0 auto;
        position: relative;
    }

    .search-bar {
        display: flex;
        background: #111;
        border: 2px solid #222;
        border-radius: 60px;
        overflow: hidden;
        transition: all 0.3s;
    }

        .search-bar:focus-within {
            border-color: #47b2e4;
            box-shadow: 0 0 30px rgba(71, 178, 228, 0.3);
        }

    .search-input {
        flex: 1;
        background: transparent;
        border: none;
        padding: 18px 30px;
        color: white;
        font-size: 1.1rem;
        outline: none;
    }

        .search-input::placeholder {
            color: #666;
        }

    .search-btn {
        background: #47b2e4;
        border: none;
        padding: 18px 40px;
        color: white;
        font-weight: 700;
        cursor: pointer;
        transition: all 0.3s;
    }

        .search-btn:hover {
            background: #2d8fc7;
        }

    /* Categories Grid */
    .categories-section {
        padding: 80px 0;
        background: #000;
    }

    .categories-grid {
        display: grid;
        grid-template-columns: repeat(auto-fit, minmax(250px, 1fr));
        gap: 30px;
        margin-top: 50px;
    }

    .category-card {
        background: linear-gradient(135deg, #0a0a0a 0%, #1a1a1a 100%);
        border: 1px solid #222;
        border-radius: 20px;
        padding: 40px 30px;
        text-align: center;
        cursor: pointer;
        transition: all 0.4s;
    }

        .category-card:hover {
            transform: translateY(-10px);
            border-color: #47b2e4;
            box-shadow: 0 15px 40px rgba(71, 178, 228, 0.2);
        }

    .category-icon {
        font-size: 3.5rem;
        color: #47b2e4;
        margin-bottom: 20px;
    }

    .category-name {
        font-size: 1.3rem;
        font-weight: 700;
        color: white;
        margin-bottom: 10px;
    }

    .category-count {
        color: #888;
        font-size: 0.9rem;
    }

    /* Featured Deals Banner */
    .deals-banner {
        background: linear-gradient(135deg, #47b2e4 0%, #2d8fc7 100%);
        padding: 60px 0;
        margin: 80px 0;
        position: relative;
        overflow: hidden;
    }

        .deals-banner::before {
            content: '';
            position: absolute;
            top: -50%;
            left: -10%;
            width: 500px;
            height: 500px;
            background: rgba(255, 255, 255, 0.1);
            border-radius: 50%;
        }

    .deals-content {
        position: relative;
        z-index: 2;
        text-align: center;
    }

    .deals-title {
        font-size: 3rem;
        font-weight: 800;
        color: white;
        margin-bottom: 15px;
    }

    .deals-subtitle {
        font-size: 1.3rem;
        color: rgba(255, 255, 255, 0.9);
        margin-bottom: 30px;
    }

    .deals-countdown {
        display: flex;
        justify-content: center;
        gap: 20px;
        margin-top: 30px;
    }

    .countdown-item {
        background: rgba(0, 0, 0, 0.3);
        padding: 20px 30px;
        border-radius: 15px;
        backdrop-filter: blur(10px);
    }

    .countdown-number {
        font-size: 2.5rem;
        font-weight: 800;
        color: white;
        display: block;
    }

    .countdown-label {
        font-size: 0.9rem;
        color: rgba(255, 255, 255, 0.8);
        text-transform: uppercase;
    }

    /* Brands Section */
    .brands-section {
        padding: 80px 0;
        background: #0a0a0a;
        border-top: 1px solid #222;
        border-bottom: 1px solid #222;
    }

    .brands-grid {
        display: grid;
        grid-template-columns: repeat(auto-fit, minmax(180px, 1fr));
        gap: 30px;
        margin-top: 50px;
    }

    .brand-card {
        background: #111;
        border: 1px solid #222;
        border-radius: 15px;
        padding: 30px;
        display: flex;
        align-items: center;
        justify-content: center;
        transition: all 0.3s;
        cursor: pointer;
    }

        .brand-card:hover {
            border-color: #47b2e4;
            transform: scale(1.05);
        }

    .brand-logo {
        font-size: 1.5rem;
        font-weight: 700;
        color: #888;
        transition: all 0.3s;
    }

    .brand-card:hover .brand-logo {
        color: #47b2e4;
    }

    /* Newsletter Section */
    .newsletter-section {
        background: linear-gradient(135deg, #1a1a1a 0%, #0a0a0a 100%);
        padding: 80px 0;
        border-top: 1px solid #222;
    }

    .newsletter-content {
        max-width: 700px;
        margin: 0 auto;
        text-align: center;
    }

    .newsletter-title {
        font-size: 2.5rem;
        font-weight: 800;
        background: linear-gradient(to right, #ffffff, #47b2e4);
        -webkit-background-clip: text;
        -webkit-text-fill-color: transparent;
        margin-bottom: 15px;
    }

    .newsletter-description {
        color: #888;
        font-size: 1.1rem;
        margin-bottom: 40px;
    }

    .newsletter-form {
        display: flex;
        gap: 15px;
        max-width: 600px;
        margin: 0 auto;
    }

    .newsletter-input {
        flex: 1;
        background: #111;
        border: 2px solid #222;
        border-radius: 50px;
        padding: 18px 30px;
        color: white;
        font-size: 1rem;
        outline: none;
        transition: all 0.3s;
    }

        .newsletter-input:focus {
            border-color: #47b2e4;
        }

    .newsletter-btn {
        background: #47b2e4;
        color: white;
        border: none;
        padding: 18px 40px;
        border-radius: 50px;
        font-weight: 700;
        cursor: pointer;
        transition: all 0.3s;
    }

        .newsletter-btn:hover {
            background: #2d8fc7;
            transform: translateY(-2px);
        }

    /* Testimonials Section */
    .testimonials-section {
        padding: 80px 0;
        background: #000;
    }

    .testimonials-grid {
        display: grid;
        grid-template-columns: repeat(auto-fit, minmax(300px, 1fr));
        gap: 30px;
        margin-top: 50px;
    }

    .testimonial-card {
        background: #0a0a0a;
        border: 1px solid #222;
        border-radius: 20px;
        padding: 40px;
        position: relative;
    }

    .testimonial-quote {
        font-size: 3rem;
        color: #47b2e4;
        opacity: 0.3;
        position: absolute;
        top: 20px;
        left: 20px;
    }

    .testimonial-text {
        color: #aaa;
        line-height: 1.8;
        margin-bottom: 25px;
        position: relative;
        z-index: 1;
    }

    .testimonial-author {
        display: flex;
        align-items: center;
        gap: 15px;
    }

    .testimonial-avatar {
        width: 50px;
        height: 50px;
        border-radius: 50%;
        background: linear-gradient(135deg, #47b2e4, #2d8fc7);
        display: flex;
        align-items: center;
        justify-content: center;
        color: white;
        font-weight: 700;
        font-size: 1.2rem;
    }

    .testimonial-info h4 {
        color: white;
        font-size: 1rem;
        margin-bottom: 5px;
    }

    .testimonial-info p {
        color: #666;
        font-size: 0.85rem;
        margin: 0;
    }

    /* Stats Section */
    .stats-section {
        background: linear-gradient(135deg, #47b2e4 0%, #2d8fc7 100%);
        padding: 60px 0;
    }

    .stats-grid {
        display: grid;
        grid-template-columns: repeat(auto-fit, minmax(200px, 1fr));
        gap: 40px;
    }

    .stat-item {
        text-align: center;
    }

    .stat-number {
        font-size: 3.5rem;
        font-weight: 800;
        color: white;
        margin-bottom: 10px;
    }

    .stat-label {
        font-size: 1.1rem;
        color: rgba(255, 255, 255, 0.9);
        font-weight: 600;
    }

    /* Trust Badges */
    .trust-section {
        background: #0a0a0a;
        padding: 60px 0;
        border-top: 1px solid #222;
    }

    .trust-grid {
        display: grid;
        grid-template-columns: repeat(auto-fit, minmax(250px, 1fr));
        gap: 40px;
        margin-top: 40px;
    }

    .trust-item {
        text-align: center;
    }

    .trust-icon {
        font-size: 3rem;
        color: #47b2e4;
        margin-bottom: 20px;
    }

    .trust-title {
        font-size: 1.2rem;
        font-weight: 700;
        color: white;
        margin-bottom: 10px;
    }

    .trust-description {
        color: #888;
        font-size: 0.95rem;
        line-height: 1.6;
    }

    /* Quick View Overlay Enhancement */
    .quick-view-overlay {
        position: absolute;
        top: 0;
        left: 0;
        right: 0;
        bottom: 0;
        background: rgba(0, 0, 0, 0.8);
        display: flex;
        align-items: center;
        justify-content: center;
        opacity: 0;
        transition: all 0.3s;
        cursor: pointer;
    }

    .img-container:hover .quick-view-overlay {
        opacity: 1;
    }

    /* Responsive */
    @@media (max-width: 768px) {
        .hero-title {
            font-size: 2.5rem;
        }

        .deals-title {
            font-size: 2rem;
        }

        .newsletter-form {
            flex-direction: column;
        }

        .deals-countdown {
            flex-wrap: wrap;
        }

        .hero-cta {
            flex-direction: column;
            align-items: center;
        }
    }
</style>

<!-- ========== HERO BANNER ========== -->
<section class="hero-banner">
    <div class="container">
        <div class="row align-items-center">
            <div class="col-lg-6 hero-content">
                <h1 class="hero-title">Premium Collection</h1>
                <p class="hero-subtitle">Discover exclusive luxury items that define your style. Limited edition pieces crafted for perfection.</p>
                <div class="hero-cta">
                    <a href="#portfolio" class="btn-primary-cta">Shop Now</a>
                    <a href="#categories" class="btn-secondary-cta">Explore Categories</a>
                </div>
            </div>
            <div class="col-lg-6">
                <div style="text-align: center; padding: 40px;">
                    <i class="bi bi-bag-heart" style="font-size: 15rem; color: #47b2e4; opacity: 0.2;"></i>
                </div>
            </div>
        </div>
    </div>
</section>

<!-- ========== : SEARCH BAR ========== -->
<section class="search-section">
    <div class="container">
        <div class="search-bar-container">
            <div class="search-bar">
                <input type="text" class="search-input" id="mainSearch" placeholder="Search for products, brands, or categories...">
                <button class="search-btn" onclick="performMainSearch()">
                    <i class="bi bi-search"></i> Search
                </button>
            </div>
        </div>
    </div>
</section>

<!-- ========== FEATURED DEALS BANNER ========== -->
<section class="deals-banner">
    <div class="container">
        <div class="deals-content">
            <h2 class="deals-title">Flash Sale! Up to 50% Off</h2>
            <p class="deals-subtitle">Limited time offer on selected premium items</p>
            <a href="#portfolio" class="btn-add-bag" style="display: inline-block; width: auto; padding: 18px 45px;">Shop Deals Now</a>
            <div class="deals-countdown">
                <div class="countdown-item">
                    <span class="countdown-number" id="hours">12</span>
                    <span class="countdown-label">Hours</span>
                </div>
                <div class="countdown-item">
                    <span class="countdown-number" id="minutes">34</span>
                    <span class="countdown-label">Minutes</span>
                </div>
                <div class="countdown-item">
                    <span class="countdown-number" id="seconds">56</span>
                    <span class="countdown-label">Seconds</span>
                </div>
            </div>
        </div>
    </div>
</section>

<!-- ==========  PORTFOLIO SECTION ) ========== -->
<section id="portfolio" class="portfolio">
    <div class="container">
        <div class="collection-header" data-aos="fade-up">
            <h2>Luxury Selection</h2>
        </div>

        <ul class="portfolio-filters" data-aos="fade-up">
            <li data-filter="*" class="filter-active">All Items</li>
            <li data-filter=".filter-1">Men</li>
            <li data-filter=".filter-2">Women</li>
            <li data-filter=".filter-3">Accessories</li>
        </ul>

        <div class="row gy-5 isotope-container">
            @If Model IsNot Nothing Then
                @For Each item In Model
                    @Code
                        ' Définition dynamique du chemin d'image
                        Dim photoPath = Url.Content("~/Assets/css/img/" & If(String.IsNullOrEmpty(item.photo), "default.jpg", item.photo))
                        ' Récupération sécurisée de la description depuis la base de données (SQL Server)
                        Dim productDesc = If(String.IsNullOrEmpty(item.description), "Experience the pinnacle of luxury with this exclusive piece.", item.description)
                    End Code

                    @<div class="col-lg-3 col-md-4 col-sm-6 portfolio-item filter-@item.Catid">
                        <div class="product-card">
                            <div class="img-container">
                                <img src="@photoPath" alt="@item.name">
                                <div class="quick-view-overlay" onclick="openQuickView(@item.id, '@item.name', '@item.Price', '@photoPath', '@productDesc')">
                                    <i class="bi bi-eye-fill" style="font-size: 2.5rem; color: #47b2e4;"></i>
                                </div>
                            </div>
                            <div class="mt-4 px-2">
                                <h6 class="fw-bold mb-1 text-uppercase" style="letter-spacing: 1px;">@item.name</h6>
                                <div class="d-flex justify-content-between align-items-center">
                                    <span class="fw-bold" style="color: #47b2e4; font-size: 1.2rem;">$@item.Price</span>
                                    <i class="bi bi-bag-plus fs-4" style="cursor:pointer" onclick="addToCart(@item.id, '@item.name', '@item.Price', '@photoPath')"></i>
                                </div>
                            </div>
                        </div>
                    </div>
                Next
            End If
        </div>
    </div>
</section>

<!-- ========== STATS SECTION ========== -->
<section class="stats-section">
    <div class="container">
        <div class="stats-grid">
            <div class="stat-item">
                <div class="stat-number">10K+</div>
                <div class="stat-label">Happy Customers</div>
            </div>
            <div class="stat-item">
                <div class="stat-number">500+</div>
                <div class="stat-label">Premium Products</div>
            </div>
            <div class="stat-item">
                <div class="stat-number">50+</div>
                <div class="stat-label">Luxury Brands</div>
            </div>
            <div class="stat-item">
                <div class="stat-number">99%</div>
                <div class="stat-label">Satisfaction Rate</div>
            </div>
        </div>
    </div>
</section>

<!-- ========== BRANDS SECTION ========== -->
<section class="brands-section">
    <div class="container">
        <div class="collection-header">
            <h2>Featured Brands</h2>
        </div>
        <div class="brands-grid">
            <div class="brand-card">
                <div class="brand-logo">GUCCI</div>
            </div>
            <div class="brand-card">
                <div class="brand-logo">PRADA</div>
            </div>
            <div class="brand-card">
                <div class="brand-logo">VERSACE</div>
            </div>
            <div class="brand-card">
                <div class="brand-logo">DIOR</div>
            </div>
            <div class="brand-card">
                <div class="brand-logo">CHANEL</div>
            </div>
            <div class="brand-card">
                <div class="brand-logo">ARMANI</div>
            </div>
        </div>
    </div>
</section>

<!-- ========== TRUST BADGES ========== -->
<section class="trust-section">
    <div class="container">
        <div class="trust-grid">
            <div class="trust-item">
                <div class="trust-icon">
                    <i class="bi bi-shield-check"></i>
                </div>
                <div class="trust-title">Secure Payment</div>
                <div class="trust-description">100% secure transactions with SSL encryption</div>
            </div>
            <div class="trust-item">
                <div class="trust-icon">
                    <i class="bi bi-truck"></i>
                </div>
                <div class="trust-title">Free Shipping</div>
                <div class="trust-description">Free worldwide delivery on orders over $100</div>
            </div>
            <div class="trust-item">
                <div class="trust-icon">
                    <i class="bi bi-arrow-repeat"></i>
                </div>
                <div class="trust-title">Easy Returns</div>
                <div class="trust-description">30-day money-back guarantee</div>
            </div>
            <div class="trust-item">
                <div class="trust-icon">
                    <i class="bi bi-headset"></i>
                </div>
                <div class="trust-title">24/7 Support</div>
                <div class="trust-description">Dedicated customer service team</div>
            </div>
        </div>
    </div>
</section>

<!-- ==========  TESTIMONIALS ========== -->
<section class="testimonials-section">
    <div class="container">
        <div class="collection-header">
            <h2>What Our Customers Say</h2>
        </div>
        <div class="testimonials-grid">
            <div class="testimonial-card">
                <div class="testimonial-quote">"</div>
                <p class="testimonial-text">The quality is exceptional! I've never been more satisfied with an online purchase. The delivery was fast and the packaging was premium.</p>
                <div class="testimonial-author">
                    <div class="testimonial-avatar">JD</div>
                    <div class="testimonial-info">
                        <h4>John Davis</h4>
                        <p>Verified Buyer</p>
                    </div>
                </div>
            </div>
            <div class="testimonial-card">
                <div class="testimonial-quote">"</div>
                <p class="testimonial-text">Outstanding customer service and authentic luxury products. Leader Store is now my go-to destination for premium shopping.</p>
                <div class="testimonial-author">
                    <div class="testimonial-avatar">SM</div>
                    <div class="testimonial-info">
                        <h4>Sarah Martinez</h4>
                        <p>VIP Customer</p>
                    </div>
                </div>
            </div>
            <div class="testimonial-card">
                <div class="testimonial-quote">"</div>
                <p class="testimonial-text">Incredible selection of high-end products. The website is easy to navigate and the checkout process is smooth and secure.</p>
                <div class="testimonial-author">
                    <div class="testimonial-avatar">RJ</div>
                    <div class="testimonial-info">
                        <h4>Robert Johnson</h4>
                        <p>Regular Customer</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

<!-- ==========NEWSLETTER ========== -->
<section class="newsletter-section">
    <div class="container">
        <div class="newsletter-content">
            <h2 class="newsletter-title">Join Our VIP Club</h2>
            <p class="newsletter-description">Subscribe to get exclusive deals, early access to sales, and luxury style tips delivered to your inbox.</p>
            <form class="newsletter-form" onsubmit="subscribeNewsletter(event)">
                <input type="email" class="newsletter-input" placeholder="Enter your email address" required>
                <button type="submit" class="newsletter-btn">Subscribe</button>
            </form>
        </div>
    </div>
</section>

<!-- ========== MODAL (D) ========== -->
<div class="modal fade" id="quickViewModal" tabindex="-1" aria-hidden="true">
    <div class="modal-dialog modal-dialog-centered modal-lg">
        <div class="modal-content shadow-lg">
            <div class="modal-body p-5">
                <button type="button" class="btn-close btn-close-white position-absolute end-0 top-0 m-4" data-bs-dismiss="modal"></button>
                <div class="row align-items-center">
                    <div class="col-md-6">
                        <img id="qv-img" src="" class="img-fluid rounded-4 shadow-lg">
                    </div>
                    <div class="col-md-6 ps-md-5 mt-4 mt-md-0">
                        <span style="color: #47b2e4; font-weight: 700; font-size: 0.8rem; letter-spacing: 3px;">LEADER STORE EXCLUSIVE</span>
                        <h2 id="qv-title" class="modal-title mt-2"></h2>
                        <div id="qv-price" class="modal-price mt-2"></div>

                        <p id="qv-desc" class="modal-description"></p>

                        <button id="qv-add-btn" class="btn-add-bag mt-3">
                            ADD TO SHOPPING BAG
                        </button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
<script src="https://unpkg.com/isotope-layout@3/dist/isotope.pkgd.min.js"></script>

<script>
    /**
     * ========== YOUR ORIGINAL JAVASCRIPT (UNCHANGED) ==========
     */

    /**
     * 1. Initialisation d'Isotope pour le filtrage fluide (Filtering Engine)
     */
    $(window).on('load', function () {
        var portfolioIsotope = $('.isotope-container').isotope({
            itemSelector: '.portfolio-item',
            layoutMode: 'fitRows'
        });

        $('.portfolio-filters li').on('click', function () {
            $(".portfolio-filters li").removeClass('filter-active');
            $(this).addClass('filter-active');
            portfolioIsotope.isotope({ filter: $(this).data('filter') });
        });
    });

    /**
     * 2. Fonction Quick View : Injection de données dynamiques dans le DOM
     */
    function openQuickView(id, title, price, img, desc) {
        document.getElementById('qv-title').innerText = title;
        document.getElementById('qv-price').innerText = '$' + price;
        document.getElementById('qv-img').src = img;
        document.getElementById('qv-desc').innerText = desc;

        document.getElementById('qv-add-btn').onclick = function () {
            addToCart(id, title, price, img);
            bootstrap.Modal.getInstance(document.getElementById('quickViewModal')).hide();
        };

        new bootstrap.Modal(document.getElementById('quickViewModal')).show();
    }

    /**
     * 3. Système de Panier : LocalStorage & Notifications SweetAlert2
     */
    function addToCart(id, title, price, img) {
        let cart = JSON.parse(localStorage.getItem('userCart')) || [];
        cart.push({ id, title, price: '$' + price, img });
        localStorage.setItem('userCart', JSON.stringify(cart));

        if (window.updateCartUI) updateCartUI();

        Swal.fire({
            toast: true,
            position: 'top-end',
            icon: 'success',
            title: title + ' ajouté au panier !',
            showConfirmButton: false,
            timer: 2500,
            background: '#111',
            color: '#fff',
            iconColor: '#47b2e4'
        });
    }

    /**
     * ========== NEW JAVASCRIPT FUNCTIONS ==========
     */

    /**
     * Search functionality
     */
    function performMainSearch() {
        const searchTerm = document.getElementById('mainSearch').value.toLowerCase();
        if (searchTerm) {
            $('.isotope-container').isotope({
                filter: function () {
                    const name = $(this).find('h6').text().toLowerCase();
                    return name.includes(searchTerm);
                }
            });

            // Scroll to products
            document.getElementById('portfolio').scrollIntoView({ behavior: 'smooth' });
        }
    }

    // Enter key support for search
    document.getElementById('mainSearch').addEventListener('keypress', function (e) {
        if (e.key === 'Enter') {
            performMainSearch();
        }
    });

    /**
     * Category filter from category cards
     */
    function filterByCategory(category) {
        $('.isotope-container').isotope({ filter: category });

        // Update active filter in portfolio filters
        $('.portfolio-filters li').removeClass('filter-active');
        $('.portfolio-filters li[data-filter="' + category + '"]').addClass('filter-active');

        // Scroll to products
        document.getElementById('portfolio').scrollIntoView({ behavior: 'smooth' });
    }

    /**
     * Newsletter subscription
     */
    function subscribeNewsletter(event) {
        event.preventDefault();
        const email = event.target.querySelector('input[type="email"]').value;

        Swal.fire({
            icon: 'success',
            title: 'Successfully Subscribed!',
            text: 'Thank you for joining our VIP club! Check your email for exclusive offers.',
            background: '#111',
            color: '#fff',
            confirmButtonColor: '#47b2e4'
        });

        event.target.reset();
    }

    /**
     * Countdown timer
     */
    function startCountdown() {
        // Set countdown to 12 hours from now
        let endTime = new Date().getTime() + (12 * 60 * 60 * 1000);

        setInterval(function () {
            let now = new Date().getTime();
            let distance = endTime - now;

            let hours = Math.floor((distance % (1000 * 60 * 60 * 24)) / (1000 * 60 * 60));
            let minutes = Math.floor((distance % (1000 * 60 * 60)) / (1000 * 60));
            let seconds = Math.floor((distance % (1000 * 60)) / 1000);

            document.getElementById('hours').textContent = hours.toString().padStart(2, '0');
            document.getElementById('minutes').textContent = minutes.toString().padStart(2, '0');
            document.getElementById('seconds').textContent = seconds.toString().padStart(2, '0');

            if (distance < 0) {
                endTime = new Date().getTime() + (12 * 60 * 60 * 1000);
            }
        }, 1000);
    }

    // Start countdown when page loads
    $(document).ready(function () {
        startCountdown();
    });
</script>
