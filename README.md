# ELO Replica - Point of Sale Project

## Overview
This repository contains an ELO replica, a point of sale project developed during a visual programming course. The project, created using Windows Forms Application, features two modules: Customer and Admin. The Customer module allows users to sign in, sign up, search for items, place orders, and filter products. The Admin module enables administrators to manage products, update item details, and perform administrative tasks. All data, including images, is stored in an SQL Server database.

## Features

### Customer Module
- **Sign In/Sign Up**:
  - Sign In requires Email and Password.
  - Sign Up requires Full Name, Email, and Password.
- **Item Display**:
  - Items are displayed in a Grid View.
- **Search Items**:
  - Search by item Name or Category Name.
- **Order Items**:
  - Provide item specifications and delivery address.
- **Filter Items**:
  - Filter based on Name, Category and Gender

### Admin Module
- **Sign In/Sign Up**:
  - Sign In requires Email and Password.
  - Sign Up requires Full Name, Phone Number, CNIC, Email, and Password.
- **Manage Items**:
  - Add new items for customers.
  - Delete any particular item.
  - Search specific items and update their price and quantity.

## Technology Stack
- **Frontend**: Windows Forms Application
- **Database**: SQL Server

## Installation and Setup

1. Clone the repository:
    ```bash
    git clone https://github.com/usamafayaz/ELO-Replica.git
    ```

2. Navigate to the project directory:
    ```bash
    cd ELO-Replica
    ```

3. Open the project in Visual Studio.

4. Configure the SQL Server database connection in the application settings.

5. Build and run the project.

## Usage
- **Customer Module**: Sign in or sign up to browse and order items.
- **Admin Module**: Sign in or sign up to manage product listings.


## Contact
For any inquiries or support, please contact [usama.fayyaz157@gmail.com].
