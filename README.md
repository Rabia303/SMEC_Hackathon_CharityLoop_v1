# NGO Donation and Management Platform

## Overview
The **NGO Donation and Management Platform** is a web-based application designed to simplify the process of clothing donations and disposals. This platform connects users with registered NGOs, promotes sustainable practices, and offers incentives like redeemable vouchers from partner brands. It includes an **admin panel** for managing NGOs, user activities, and brand collaborations.

---

## Problem Statement
Improper disposal of unused clothes contributes to environmental pollution and textile waste. Individuals often lack accessible solutions to donate or dispose of clothing sustainably. Simultaneously, organizations and brands promoting sustainability face challenges in engaging donors effectively. This project aims to bridge these gaps by creating a platform that simplifies the donation and disposal process while incentivizing eco-friendly behavior.

---

## Features

### User Module:
- **Registration and Login**: Secure account creation using email or phone number.
- **Clothes Donation**:
  - Select nearby NGOs for donations.
  - Schedule pickups or drop-offs with NGOs.
- **Clothes Disposal**:
  - Eco-friendly pickup scheduling for clothes unsuitable for donation.
- **Incentives**:
  - Earn and redeem vouchers for donations.
- **Tracking**:
  - Monitor donation/disposal status (e.g., "Pending," "Picked Up," "Delivered").

### Admin Module:
- **NGO Management**:
  - Add, update, or remove NGOs.
  - Monitor NGO activity and performance.
- **Brand Management**:
  - Manage partner brands and voucher rules.
- **Activity Dashboard**:
  - Track all user activities and engagement metrics.
- **User Management**:
  - Oversee user profiles and resolve issues.

---

## Technology Stack

### Frontend:
- **Framework**: Bootstrap
- **Features**: Responsive design for both user and admin panels

### Backend:
- **Framework**: .NET
- **Features**:
  - Secure API endpoints
  - Real-time notifications and data handling

### Database:
- **SQL Server**:
  - Optimized queries and stored procedures for data handling

### Third-Party Integrations:
1. **Map Integration**: Locate NGOs and schedule pickups/drop-offs.
2. **Voucher System**: Integration with brand APIs for voucher validation.
3. **Notification System**: Email and SMS alerts for users and NGOs.

---

## How to Set Up and Use

### Prerequisites:
1. **Tools**:
   - Visual Studio 2022 or higher
   - SQL Server
   - Web browser (e.g., Chrome, Edge)
   - (Optional) Postman for API testing
2. **Packages**:
   - .NET Core 6.0 SDK
   - Pre-configured Bootstrap (included in project files)

### Steps to Set Up the Project:
1. **Clone the Repository**:
   ```bash
   git clone https://github.com/your-username/ngo-management-platform.git
   cd ngo-management-platform
   ```

2. **Set Up SQL Server Database**:
   - Open SQL Server Management Studio (SSMS).
   - Create a database (e.g., `NGO_Management`).
   - Run the provided SQL scripts to create tables and stored procedures.

3. **Configure Connection String**:
   - Update the `appsettings.json` file:
     ```json
     "ConnectionStrings": {
       "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=NGO_Management;User Id=YOUR_USERNAME;Password=YOUR_PASSWORD;"
     }
     ```

4. **Restore NuGet Packages**:
   - In Visual Studio, go to **Tools > NuGet Package Manager > Manage NuGet Packages for Solution** and restore dependencies.

5. **Run the Project**:
   - Set the startup project (e.g., `NGO.Web`).
   - Press `F5` to start the application.

### How to Use:
1. **Access**:
   - Use `/User` for the user panel.
   - Use `/Admin` for the admin panel.
2. **Register and Login**:
   - Create an account to access features.
   - Admin credentials can be configured in the database.
3. **Explore**:
   - Donate or dispose of clothes.
   - Admins manage NGOs, brands, and users.

---

## Challenges and Solutions
- **Challenge**: API integration issues
  - **Solution**: Modular architecture ensured smooth API communication.
- **Challenge**: Managing large datasets in SQL Server
  - **Solution**: Implemented indexing and optimized stored procedures.


---

## Contact
For queries or contributions, reach out to [your-email@example.com](mailto:rabiaimtiaz203@gmail.com).

