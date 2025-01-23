Sure! Here's the updated version of the README with your requested adjustments:

---

# NGO Donation and Management Platform

---

## 🌟 Overview

The **NGO Donation and Management Platform** is a transformative solution designed to connect individuals with non-governmental organizations (NGOs). The platform promotes **sustainability** by simplifying clothing donations and eco-friendly disposals while incentivizing users through **redeemable vouchers** from partner brands.

This platform includes:

- A **user-friendly interface** for donors.
- A **powerful admin dashboard** for NGOs to manage operations, partnerships, and engagement efficiently.
- **Scalable architecture** to drive social impact using technology.

---

## 🚩 Problem Statement

Clothing waste is a growing contributor to environmental pollution. Traditional donation and disposal systems often fail due to:

- Lack of accessibility.
- Inefficiency in operations.
- Absence of user engagement strategies.

This platform solves these problems by:

- **Simplifying donations and eco-friendly disposal**.
- **Incentivizing users** through brand vouchers.
- **Optimizing NGO operations** with a centralized management system.

---

## 🔑 Key Features

### 🛠 User Module:

1. **Account Management:**
   - Secure registration and login via email or phone.
2. **Clothes Donation:**
   - Locate nearby NGOs and schedule pickups.
   - Track donation requests with status updates.
3. **Eco-Friendly Disposal:**
   - Schedule disposals for non-donatable items.
   - Real-time progress tracking.
4. **Incentives:**
   - Earn vouchers from partner brands for every successful donation.
5. **Donation Tracker:**
   - Monitor donation progress (e.g., "Pending," "Picked Up," "Delivered").

### 📊 Admin Module:

1. **NGO Management:**
   - Add, update, or remove NGOs.
   - Track NGO activities.
2. **Partner Management:**
   - Manage brand partnerships.
   - Configure voucher rules.
3. **Activity Dashboard:**
   - Monitor user activities, donations, and engagement metrics.
4. **Content Management:**
   - Edit website sections like "About Us," FAQs, and initiatives.
5. **Reports & Analytics:**
   - Generate insights to optimize operations.

---

## 🖥 Technology Stack

### Frontend:

- **HTML**: <img src="https://raw.githubusercontent.com/marwin1991/profile-technology-icons/refs/heads/main/icons/html.png" alt="HTML Logo" width="40"> - For structuring the content of the web pages.
- **CSS**: <img src="https://raw.githubusercontent.com/marwin1991/profile-technology-icons/refs/heads/main/icons/css.png" alt="CSS Logo" width="40"> - For styling and layout adjustments.
- **JavaScript**: <img src="https://raw.githubusercontent.com/marwin1991/profile-technology-icons/refs/heads/main/icons/javascript.png" alt="JavaScript Logo" width="40"> - For making the site interactive.
- **Bootstrap**: <img src="https://raw.githubusercontent.com/marwin1991/profile-technology-icons/refs/heads/main/icons/bootstrap.png" alt="Bootstrap Logo" width="40"> - For responsive design and ready-made UI components.

### Backend:

- **.NET Core**: <img src="https://static.wikia.nocookie.net/logopedia/images/c/c7/Microsoft_.NET_StartupImage.svg/revision/latest/scale-to-width-down/512?cb=20200629113510" alt=".NET Core Logo" width="40">  - Framework for building the API and server-side logic.

### Database:

- **SQL Server**: <img src="https://cdn-icons-png.flaticon.com/512/5968/5968364.png" alt="SQL Server Logo" width="40"> - For data storage and management.

---

## 🛠 Setup Guide

### Prerequisites:

1. **Software Requirements:**
   - Visual Studio 2022 or later
   - SQL Server
   - Modern web browser (e.g., Chrome, Edge)
2. **Packages:**
   - .NET Core 6.0 SDK

### Installation Steps:

1. **Clone the Repository:**
   ```bash
   git clone https://github.com/your-username/ngo-management-platform.git
   cd ngo-management-platform
   ```
2. **Database Setup:**
   - Open SQL Server Management Studio (SSMS).
   - Create a database (e.g., `NGO_Management`).
   - Execute SQL scripts in the `/Database` folder.
3. **Configure Connection String:**
   - Update `appsettings.json`:
     ```json
     "ConnectionStrings": {
       "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=NGO_Management;User Id=YOUR_USERNAME;Password=YOUR_PASSWORD;"
     }
     ```
4. **Restore Dependencies:**
   - Open Visual Studio.
   - Navigate to **Tools > NuGet Package Manager > Manage NuGet Packages for Solution**.
   - Restore missing packages.
5. **Run the Application:**
   - Set the startup project to `NGO.Web`.
   - Press `F5` to launch.

### Access Points:

- **User Panel:** Accessible at `/User` for donors.
- **Admin Panel:** Accessible at `/Admin` for administrators.

---

## 📈 Highlights

- **User-Centric Design:** Built with accessibility and usability in mind.
- **Scalable Architecture:** Seamlessly handles growing user and NGO bases.
- **Sustainability-Focused:** Encourages eco-friendly practices through incentives.

---

## 🛤 Future Roadmap

1. **Mobile App Development:**
   - Build a cross-platform mobile app using Flutter.
2. **Advanced Analytics:**
   - AI-powered insights for user engagement and NGO efficiency.
3. **Personalized Recommendations:**
   - Tailored suggestions to enhance user involvement.

---

## 🎥 Media

### Screenshots

#### Homepage

<div>
  <img src="https://raw.githubusercontent.com/Rabia303/SMEC_Hackathon_CharityLoop_v1/master/web1.PNG" width="250" height="150"> 
  <img src="https://raw.githubusercontent.com/Rabia303/SMEC_Hackathon_CharityLoop_v1/master/web2.PNG" width="250" height="150"> 
  <img src="https://raw.githubusercontent.com/Rabia303/SMEC_Hackathon_CharityLoop_v1/master/web3.PNG" width="250" height="150"> 

</div>

#### Admin Dashboard

<div>
  <img src="https://raw.githubusercontent.com/Rabia303/SMEC_Hackathon_CharityLoop_v1/master/add1.PNG" width="250" height="150"> 
  <img src="https://raw.githubusercontent.com/Rabia303/SMEC_Hackathon_CharityLoop_v1/master/add2.PNG" width="250" height="150"> 
  <img src="https://raw.githubusercontent.com/Rabia303/SMEC_Hackathon_CharityLoop_v1/master/add6.PNG" width="250" height="150"> 
</div>


### Video Demo

[Watch the Demo](https://github.com/Rabia303/SMEC_Hackathon_CharityLoop_v1/blob/master/charity_loop_demo_vedio.mp4)

---

## ✉ Contact

For inquiries or contributions, please email: [rabiaimtiaz203@gmail.com](mailto:rabiaimtiaz203@gmail.com).

---

This version adjusts the formatting and clarifies the role of each technology in your stack. Let me know if you’d like any more modifications!
