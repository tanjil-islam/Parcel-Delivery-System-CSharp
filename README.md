# Parcel Delivery System (C#)

## Overview
The Parcel Delivery System is a Windows desktop application designed for logistics companies to efficiently manage parcel deliveries. It includes features for tracking orders, managing users, and updating delivery statuses.
This project demonstrates object-oriented programming principles, database connectivity, and a practical application of C# with WinForms.

---

## Features
### Core Functionalities
- **User Roles**:
  - **Admin**: Manage employees and oversee system operations.
  - **Customer**: Create and manage parcel orders.
  - **Employee**: Handle delivery updates and transit tracking.

- **Parcel Tracking**:
  - Create, update, cancel, or complete parcel orders.
  - Monitor parcel statuses in real-time.

- **Database Integration**:
  - Persistent data storage using SQL Server.
  - Retrieve parcel history and order details.

---

## Technologies Used
- **Programming Language**: C#
- **Framework**: WinForms (Windows Forms)
- **Database**: SQL Server
- **IDE**: Visual Studio
- **Other Tools**: ADO.NET for database connectivity.

---
## Folder Structure
- **Admin_/**: Code for admin-related functionalities.
- **Customer_/**: Code for customer-related functionalities.
- **Employee_/**: Code for employee-related functionalities.
- **Resources/**: Assets such as icons or images.
- **Properties/**: Project settings and configurations.

- Parcel-Delivery-System-CSharp/
├── Admin_/
├── Customer_/
├── Employee_/
├── Resources/
├── Properties/
├── .gitignore
├── Admin.cs
├── App.config
├── CancelOrder.cs
├── CompleteOrder.cs
├── DBAccess.cs
├── Login.cs
├── Program.cs
├── TransitOrder.cs
├── Parcel_Delivery_Management_System.csproj


## How to Run
1. Clone the repository:
   ```bash
   git clone https://github.com/tanjil-islam/Parcel-Delivery-System-CSharp.git
