<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <meta content="width=device-width, initial-scale=1.0" name="viewport">
    <title>@ViewBag.Title - LEADER STORE</title>

    <link href="https://fonts.googleapis.com/css2?family=Plus+Jakarta+Sans:wght@300;400;600;800&family=Jost:wght@300;400;600;700&display=swap" rel="stylesheet">

    <link href="@Url.Content("~/assets/vendor/bootstrap/css/bootstrap.min.css")" rel="stylesheet">
    <link href="@Url.Content("~/assets/vendor/bootstrap-icons/bootstrap-icons.css")" rel="stylesheet">
    <link href="@Url.Content("~/assets/vendor/aos/aos.css")" rel="stylesheet">
    <link href="@Url.Content("~/assets/vendor/glightbox/css/glightbox.min.css")" rel="stylesheet">
    <link href="@Url.Content("~/assets/vendor/swiper/swiper-bundle.min.css")" rel="stylesheet">
    <link href="@Url.Content("~/assets/css/main.css")" rel="stylesheet">

    <style>
        :root {
            --primary-color: #47b2e4;
            --dark-bg: #0b0b0b;
            --card-bg: #151515;
            --input-bg: #1d1d1d;
        }

        body {
            background-color: var(--dark-bg);
            font-family: 'Plus Jakarta Sans', sans-serif;
            color: #ffffff;
            overflow-x: hidden;
        }

        /* 1. Header Glassmorphism */
        #header {
            background: rgba(11, 11, 11, 0.8) !important;
            backdrop-filter: blur(15px);
            border-bottom: 1px solid rgba(255, 255, 255, 0.05);
            padding: 15px 0;
            transition: 0.3s;
        }

        .sitename {
            font-weight: 800;
            background: linear-gradient(45deg, #fff, var(--primary-color));
            -webkit-background-clip: text;
            -webkit-text-fill-color: transparent;
            font-size: 24px;
        }

        .navmenu a {
            color: rgba(255, 255, 255, 0.7) !important;
            font-weight: 500;
        }

            .navmenu a:hover, .navmenu .active {
                color: var(--primary-color) !important;
            }

        /* 2. Hero Section */
        .hero {
            padding: 160px 0 100px 0;
            background: radial-gradient(circle at top right, rgba(71, 178, 228, 0.1), transparent);
        }

            .hero h1 {
                font-size: 60px;
                font-weight: 800;
                line-height: 1.1;
            }

        .btn-get-started {
            background: var(--primary-color);
            padding: 12px 35px;
            border-radius: 50px;
            font-weight: 600;
            color: #fff;
            border: 2px solid var(--primary-color);
            transition: 0.3s;
            text-decoration: none;
            display: inline-block;
        }

            .btn-get-started:hover {
                background: transparent;
                color: var(--primary-color);
            }

        /* 3. Contact Section Dark Style */
        .contact {
            background-color: var(--dark-bg);
            padding: 80px 0;
        }

            .contact .info-wrap, .contact .php-email-form {
                background: var(--card-bg) !important;
                border: 1px solid #222 !important;
                border-radius: 20px;
                padding: 40px;
            }

            .contact .info-item i {
                background: rgba(71, 178, 228, 0.1);
                color: var(--primary-color);
                width: 50px;
                height: 50px;
                border-radius: 12px;
                display: flex;
                align-items: center;
                justify-content: center;
                font-size: 20px;
                margin-right: 15px;
            }

            .contact .form-control {
                background: var(--input-bg) !important;
                border: 1px solid #333 !important;
                color: #fff !important;
                border-radius: 10px;
                padding: 12px;
            }

                .contact .form-control:focus {
                    border-color: var(--primary-color) !important;
                    box-shadow: none !important;
                }

            /* Dark Map Filter */
            .contact iframe {
                border-radius: 15px;
                filter: invert(90%) hue-rotate(180deg) brightness(95%);
                margin-top: 20px;
            }

        footer {
            padding: 40px 0;
            border-top: 1px solid #222;
            text-align: center;
            color: #555;
        }
    </style>
</head>

<body>
    <header id="header" class="header d-flex align-items-center fixed-top">
        <div class="container-fluid container-xl position-relative d-flex align-items-center">
            <a href="@Url.Action("Index", "Home")" class="logo d-flex align-items-center me-auto">
                <h1 class="sitename">LEADER STORE</h1>
            </a>
            <nav id="navmenu" class="navmenu">
                <ul>
                    <li><a href="@Url.Action("Index", "Home")">Home</a></li>
                    <li><a href="@Url.Action("Category", "Home")">Categories</a></li>
                    <li><a href="#portfolio">Collections</a></li>
                    <li><a href="#contact">Contact</a></li>
                    <li>
                        <a href="@Url.Action("Cart", "Home")" class="position-relative">
                            <i class="bi bi-bag-heart fs-5"></i>
                            <span id="cart-count" class="position-absolute top-0 start-100 translate-middle badge rounded-pill bg-primary">0</span>
                        </a>
                    </li>
                </ul>
                <i class="mobile-nav-toggle d-xl-none bi bi-list"></i>
            </nav>
        </div>
    </header>

    <main class="main">
        @* Hero يبان غير ف الصفحة الرئيسية *@
        @If ViewContext.RouteData.Values("action").ToString().ToLower() = "index" Then
            @<section id="hero" class="hero section dark-background">
                <div class="container">
                    <div class="row gy-4 align-items-center">
                        <div class="col-lg-6 order-2 order-lg-1" data-aos="fade-up">
                            <h1>ELEVATE YOUR STYLE <br><span style="color: var(--primary-color)">PRIME AURA</span></h1>
                            <p class="fs-5 text-secondary">Step into the future of luxury shopping.</p>
                            <div class="d-flex mt-4">
                                <a href="#portfolio" class="btn-get-started">Start Shopping</a>
                            </div>
                        </div>
                        <div class="col-lg-6 order-1 order-lg-2" data-aos="zoom-out">
                            <img src="@Url.Content("~/assets/css/img/AA.jpeg")" class="img-fluid animated shadow-lg" style="border-radius: 30px;" alt="Hero">
                        </div>
                    </div>
                </div>
            </section>
        End If

        @RenderBody()

        <section id="contact" class="contact section">
            <div class="container section-title" data-aos="fade-up">
                <h2 class="text-white">CONTACT</h2>
                <p class="text-primary">Get In Touch With Us</p>
            </div>

            <div class="container" data-aos="fade-up">
                <div class="row gy-4">
                    <div class="col-lg-5">
                        <div class="info-wrap">
                            <div class="info-item d-flex">
                                <i class="bi bi-geo-alt"></i>
                                <div><h3>Address</h3><p>A208 NYC OMAR YAHYA</p></div>
                            </div>
                            <div class="info-item d-flex mt-4">
                                <i class="bi bi-telephone"></i>
                                <div><h3>Call Us</h3><p>+212 772265286</p></div>
                            </div>
                            <iframe src="https://www.google.com/maps/embed?pb=!1m14!1m12!1m3!1d13591.731454653606!2d-8.008272!3d31.622522!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!5e0!3m2!1sen!2sma!4v1700000000000"
                                    frameborder="0" style="border:0; width: 100%; height: 250px;" allowfullscreen></iframe>
                        </div>
                    </div>

                    <div class="col-lg-7">
                        <form action="@Url.Action("Contact", "Home")" method="post" class="php-email-form">
                            <div class="row gy-3">
                                <div class="col-md-6">
                                    <input type="text" name="name" class="form-control" placeholder="Your Name" required>
                                </div>
                                <div class="col-md-6">
                                    <input type="email" name="email" class="form-control" placeholder="Your Email" required>
                                </div>
                                <div class="col-md-12">
                                    <textarea name="message" rows="6" class="form-control" placeholder="Message" required></textarea>
                                </div>
                                <div class="col-md-12 text-center">
                                    <button type="submit" class="btn-get-started w-100">Send Message</button>
                                </div>
                            </div>
                        </form>
                    </div>
                </div>
            </div>
        </section>
    </main>

    <footer>
        <div class="container">
            <p>&copy; 2026 <strong>LEADER STORE</strong>. Designed for Excellence.</p>
        </div>
    </footer>

    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script src="@Url.Content("~/assets/vendor/bootstrap/js/bootstrap.bundle.min.js")"></script>
    <script src="@Url.Content("~/assets/vendor/aos/aos.js")"></script>
    <script src="@Url.Content("~/assets/js/main.js")"></script>

    <script>
        AOS.init({ duration: 1000, once: true });

        function updateCartCount() {
            let cart = JSON.parse(localStorage.getItem('userCart')) || [];
            let countElem = document.getElementById('cart-count');
            if (countElem) countElem.innerText = cart.length;
        }
        document.addEventListener('DOMContentLoaded', updateCartCount);
    </script>
</body>
</html>