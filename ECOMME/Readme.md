# 🛍️ LEADER STORE - Premium E-Commerce Platform

![ASP.NET](https://img.shields.io/badge/ASP.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![VB.NET](https://img.shields.io/badge/VB.NET-512BD4?style=for-the-badge&logo=.net&logoColor=white)
![Bootstrap](https://img.shields.io/badge/Bootstrap-7952B3?style=for-the-badge&logo=bootstrap&logoColor=white)
![JavaScript](https://img.shields.io/badge/JavaScript-F7DF1E?style=for-the-badge&logo=javascript&logoColor=black)

A modern, full-featured e-commerce platform built with ASP.NET MVC and VB.NET. Experience luxury shopping with cutting-edge design, smooth animations, and powerful features.

![Leader Store Preview](https://via.placeholder.com/1200x600/0b0b0b/47b2e4?text=LEADER+STORE+-+Premium+E-Commerce)

---

## ✨ Features

### 🎨 **Modern UI/UX Design**
- **Dark Theme**: Elegant black background with electric blue (#47b2e4) accents
- **Glassmorphism Effects**: Backdrop blur and transparency for modern aesthetics
- **Smooth Animations**: CSS keyframe animations and transitions throughout
- **Responsive Design**: Fully optimized for desktop, tablet, and mobile devices

### 🏪 **E-Commerce Functionality**

#### **Product Management**
- Dynamic product grid with Isotope filtering
- Category-based filtering (Men, Women, Accessories)
- Advanced search functionality
- Product quick view modal
- Image zoom on hover
- Star ratings and review counts
- "NEW" badges for featured items

#### **Shopping Cart System**
- LocalStorage-based cart management
- Real-time cart updates
- Quantity controls (+/-)
- Mini cart dropdown on hover
- Product removal with confirmation
- Animated cart badge with pulse effect
- WhatsApp order integration

#### **Advanced Filtering & Sorting**
- **Price Filters**: Under $500, $500-$1000, $1000-$2000, $2000+
- **Rating Filters**: 4★ & Above, 3★ & Above, 2★ & Above
- **Sort Options**: Featured, Price (Low/High), Top Rated, Newest
- Real-time search with instant results

#### **Promo Codes**
- Discount code system
- Valid codes: `SAVE10`, `SAVE20`, `WELCOME`
- Real-time discount calculation
- Savings badge display

### 📱 **Pages & Sections**

#### **Home Page**
- Hero banner with call-to-action
- Search bar with live filtering
- Category cards with icons
- Flash sale countdown timer
- Featured products grid
- Statistics section (10K+ customers, 500+ products)
- Trending brands showcase
- Trust badges (Secure Payment, Free Shipping, Easy Returns)
- Customer testimonials
- Newsletter subscription

#### **Categories Page**
- Animated hero section
- Category cards with hover effects
- Product count badges
- Trending Now section
- Benefits showcase
- Newsletter CTA

#### **Shopping Cart Page**
- Breadcrumb navigation
- Checkout progress steps (4 stages)
- Product table with images
- Quantity controls
- Promo code input
- Order summary with totals
- Payment method icons
- Security badges
- Recommended products section
- Empty cart state

#### **Contact Page**
- Contact form with validation
- Google Maps integration (dark mode)
- Address and phone information
- Icon-based info cards

### 🎯 **UI Components**

#### **Header**
- Announcement bar with promotions
- Glassmorphism navigation
- Search bar (desktop)
- Animated cart icon with badge
- Mini cart dropdown
- Mobile-responsive menu
- Scroll effect (changes style on scroll)

#### **Footer**
- 4-column grid layout
- Quick links
- Customer service links
- Social media icons
- Newsletter signup
- Copyright information

#### **Additional Features**
- Loading overlay with spinner
- Back-to-top button (appears after 300px scroll)
- SweetAlert2 notifications
- AOS (Animate On Scroll) library integration
- Isotope layout library for filtering

---

## 🛠️ Technologies Used

### **Backend**
- **ASP.NET MVC 5** - Web framework
- **VB.NET** - Primary programming language
- **Entity Framework** - ORM for database operations
- **SQL Server** - Database management system

### **Frontend**
- **HTML5** - Markup
- **CSS3** - Styling with modern features
  - CSS Grid & Flexbox
  - CSS Variables
  - Keyframe Animations
  - Media Queries
- **JavaScript (ES6+)** - Client-side scripting
- **jQuery 3.6.0** - DOM manipulation
- **Bootstrap 5** - Responsive framework

### **Libraries & Plugins**
- **Isotope.js** - Filtering and sorting layouts
- **SweetAlert2** - Beautiful alert popups
- **AOS (Animate On Scroll)** - Scroll animations
- **Bootstrap Icons** - Icon library
- **Google Fonts** - Plus Jakarta Sans, Space Mono, Jost

---

## 📦 Installation & Setup

### **Prerequisites**
- Visual Studio 2019 or later
- .NET Framework 4.7.2 or higher
- SQL Server 2016 or later
- IIS Express (included with Visual Studio)

### **Installation Steps**

1. **Clone the repository**
```bash
git clone https://github.com/yourusername/leader-store.git
cd leader-store
```

2. **Open in Visual Studio**
   - Open `ECOMME.sln` in Visual Studio
   - Restore NuGet packages

3. **Configure Database**
   - Update connection string in `Web.config`
```xml
<connectionStrings>
    <add name="DefaultConnection" 
         connectionString="Data Source=YOUR_SERVER;Initial Catalog=ECOMME;Integrated Security=True" 
         providerName="System.Data.SqlClient"/>
</connectionStrings>
```

4. **Run Database Migrations**
   - Open Package Manager Console
   - Run: `Update-Database`

5. **Build and Run**
   - Press `F5` or click "IIS Express"
   - Application will open at `http://localhost:44302`

---

## 📁 Project Structure

```
ECOMME/
├── Controllers/
│   ├── HomeController.vb          # Main controller
│   ├── AccountController.vb       # User authentication
│   └── ManageController.vb        # User management
├── Models/
│   ├── Product.vb                 # Product model
│   ├── Category.vb                # Category model
│   ├── Cart.vb                    # Shopping cart model
│   └── IdentityModels.vb          # User identity models
├── Views/
│   ├── Home/
│   │   ├── Index.vbhtml           # Home page (enhanced)
│   │   ├── Category.vbhtml        # Categories page
│   │   └── Cart.vbhtml            # Shopping cart
│   └── Shared/
│       └── _Layout.vbhtml         # Master layout (enhanced)
├── Assets/
│   ├── css/
│   │   ├── main.css               # Main styles
│   │   └── img/                   # Product images
│   ├── vendor/
│   │   ├── bootstrap/             # Bootstrap files
│   │   ├── aos/                   # AOS library
│   │   └── bootstrap-icons/       # Icons
│   └── js/
│       └── main.js                # Main JavaScript
└── Web.config                      # Configuration file
```

---

## 🎨 Design System

### **Color Palette**
```css
--primary-color: #47b2e4;      /* Electric Blue */
--primary-dark: #2d8fc7;       /* Dark Blue */
--accent: #00D9FF;             /* Cyan Accent */
--dark-bg: #0b0b0b;            /* Deep Black */
--card-bg: #151515;            /* Card Background */
--border: #222222;             /* Subtle Border */
--text-primary: #ffffff;       /* White Text */
--text-secondary: #888888;     /* Gray Text */
```

### **Typography**
- **Primary Font**: Plus Jakarta Sans (300, 400, 600, 800)
- **Secondary Font**: Jost (300, 400, 600, 700)
- **Accent Font**: Space Mono (400, 700)

### **Spacing Scale**
- Small: 8px, 16px, 24px
- Medium: 32px, 40px, 48px
- Large: 60px, 80px, 100px

---

## 🔧 Configuration

### **Database Models**

#### **Product Model**
```vb
Public Class Product
    Public Property id As Integer
    Public Property name As String
    Public Property Price As Decimal
    Public Property photo As String
    Public Property description As String
    Public Property Catid As Integer
End Class
```

#### **Category Model**
```vb
Public Class Category
    Public Property id As Integer
    Public Property Name As String
    Public Property photo As String
    Public Property description As String
End Class
```

### **LocalStorage Cart Structure**
```javascript
{
    id: Number,
    title: String,
    price: String,
    priceValue: Number,
    img: String,
    quantity: Number
}
```

---

## 🚀 Features in Detail

### **1. Smart Search System**
- Real-time filtering as you type
- Searches product names
- Works with category filters
- Shows "no results" message when needed

### **2. Shopping Cart**
- Persistent across sessions (LocalStorage)
- Automatic quantity tracking
- Price calculation with tax
- Mini cart preview on hover
- Promo code support
- WhatsApp order generation

### **3. Product Filtering**
- Isotope.js powered
- Smooth animations
- Multiple filter types
- Preserves scroll position

### **4. Responsive Design**
Breakpoints:
- **Mobile**: < 768px
- **Tablet**: 768px - 1024px
- **Desktop**: > 1024px

---

## 📱 Browser Support

| Browser | Version |
|---------|---------|
| Chrome | 90+ |
| Firefox | 88+ |
| Safari | 14+ |
| Edge | 90+ |
| Opera | 76+ |

---

## 🔐 Security Features

- CSRF protection
- SQL injection prevention (Entity Framework)
- XSS protection
- Secure password hashing
- HTTPS enforcement (production)

---

## 🤝 Contributing

We welcome contributions! Please follow these steps:

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

### **Coding Standards**
- Follow VB.NET naming conventions
- Use meaningful variable names
- Comment complex logic
- Test before committing

---

## 📝 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

---

## 👨‍💻 Author

**Your Name**
- GitHub: [@yourusername](https://github.com/yourusername)
- LinkedIn: [Your Name](https://linkedin.com/in/yourprofile)
- Email: your.email@example.com

---

## 🙏 Acknowledgments

- **Bootstrap** - UI Framework
- **SweetAlert2** - Beautiful alerts
- **Isotope** - Filtering library
- **AOS** - Scroll animations
- **Bootstrap Icons** - Icon library
- **Google Fonts** - Typography

---

## 📸 Screenshots

### Home Page
![Home Page](https://via.placeholder.com/800x600/0b0b0b/47b2e4?text=Home+Page)

### Categories
![Categories](https://via.placeholder.com/800x600/0b0b0b/47b2e4?text=Categories)

### Shopping Cart
![Shopping Cart](https://via.placeholder.com/800x600/0b0b0b/47b2e4?text=Shopping+Cart)

### Mobile View
![Mobile](https://via.placeholder.com/400x800/0b0b0b/47b2e4?text=Mobile+View)

---

## 🐛 Known Issues

- [ ] Safari iOS animation performance
- [ ] IE11 not supported (modern browsers only)

---

## 🗺️ Roadmap

- [ ] User authentication system
- [ ] Wishlist functionality
- [ ] Product reviews and ratings
- [ ] Admin dashboard
- [ ] Payment gateway integration
- [ ] Order tracking system
- [ ] Email notifications
- [ ] Multi-language support
- [ ] Dark/Light mode toggle
- [ ] PWA support

---

## 💬 Support

For support, email support@leaderstore.com or join our Slack channel.

---

## ⭐ Show Your Support

Give a ⭐️ if this project helped you!

---

<div align="center">
  <p>Made with ❤️ and VB.NET</p>
  <p>© 2026 LEADER STORE. All Rights Reserved.</p>
</div>
