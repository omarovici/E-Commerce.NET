# E-Commerce.NET

A robust, production-ready e-commerce platform built with ASP.NET Core 8, featuring a modular architecture for scalability and maintainability. The project supports a full product catalog, shopping cart, secure authentication, order management, and real-time payment processing via Stripe. Designed for both customers and administrators, it leverages modern .NET technologies and best practices for a seamless shopping and management experience.

[![GitHub Repo](https://img.shields.io/badge/GitHub-Repository-blue?logo=github)](https://github.com/omarovici/E-Commerce.NET)

## Table of Contents
- [Features](#features)
- [Tech Stack](#tech-stack)
- [Project Structure](#project-structure)
- [Getting Started](#getting-started)
- [Configuration](#configuration)
- [API Endpoints](#api-endpoints)
- [Usage](#usage)
- [Testing](#testing)
- [Deployment](#deployment)
- [Architecture Overview](#architecture-overview)
- [Contributing](#contributing)
- [License](#license)

## Features
- Product catalog with advanced filtering, sorting, and search
- Shopping cart and basket management (with Redis caching)
- Secure user authentication and registration (ASP.NET Identity)
- Order management and checkout process
- Stripe payment integration for real-time transactions
- Admin panel for product and order management
- RESTful API architecture
- Entity Framework Core with SQL Server
- Redis integration for caching and basket storage
- AutoMapper for DTO mapping
- Swagger/OpenAPI documentation
- Exception handling middleware
- Seeding for initial data and users

## Tech Stack
- **Backend:** ASP.NET Core 8, Entity Framework Core
- **Database:** SQL Server
- **Cache:** Redis (StackExchange.Redis)
- **Authentication:** ASP.NET Identity
- **Payments:** Stripe
- **API Documentation:** Swagger
- **Other:** AutoMapper, StackExchange.Redis

## Project Structure
```
E-Commerce.NET/
├── Store.Data/           # Data access, entities, and migrations
├── Store.Repository/     # Repository pattern, specifications, and unit of work
├── Store.Service/        # Business logic, services, DTOs, token service, payment integration
├── Store.Web/            # Web API, controllers, middleware, startup
```

## Getting Started
### Prerequisites
- [.NET 8.0 SDK](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [Redis](https://redis.io/download)
- [Stripe Account](https://dashboard.stripe.com/register) for payment processing

### Installation
1. **Clone the repository:**
   ```bash
   git clone https://github.com/omarovici/E-Commerce.NET.git
   cd E-Commerce.NET
   ```
2. **Configure connection strings and Stripe keys:**
   - Update `DefaultConnection`, `IdentityConnection`, and `Redis` in `Store.Data/Store.Web/appsettings.json` and `appsettings.Development.json`.
   - Add your Stripe API keys under the `Stripe` section:
     ```json
     "Stripe": {
       "SecretKey": "your_stripe_secret_key",
       "PublishableKey": "your_stripe_publishable_key"
     }
     ```
3. **Apply migrations and seed data:**
   - The application will automatically apply migrations and seed data on first run.
4. **Run the application:**
   ```bash
   dotnet run --project Store.Data/Store.Web/Store.Web.csproj
   ```
5. **Access the API:**
   - Swagger UI: [https://localhost:5001/swagger](https://localhost:5001/swagger)

## Configuration
- **appsettings.json**: Contains connection strings and configuration for logging, Redis, Stripe, and other services.
- **Environment Variables:**
  - `DefaultConnection`: SQL Server connection string for main data
  - `IdentityConnection`: SQL Server connection string for identity/auth
  - `Redis`: Redis connection string (e.g., `localhost:6379`)
  - `Stripe:SecretKey` and `Stripe:PublishableKey`: Stripe API keys

## API Endpoints

### Products
- `GET /api/products/getallbrands` — Get all product brands
- `GET /api/products/getalltypes` — Get all product types
- `GET /api/products/getallproducts` — List products with filtering, sorting, and pagination
- `GET /api/products/getproductbyid?id={id}` — Get product details by ID

### Basket
- `GET /api/basket/{id}` — Retrieve basket by ID
- `POST /api/basket` — Update or create basket
- `DELETE /api/basket/{id}` — Delete basket by ID

### Account
- `POST /api/account/login` — User login
- `POST /api/account/register` — User registration
- `GET /api/account/getcurrentuserdetails` — Get details of the currently authenticated user

### Orders
- `POST /api/order/createorderasync` — Create a new order
- `GET /api/order/getallordersforuserasync` — List all orders for the current user
- `GET /api/order/getorderbyidasync?id={id}` — Get order details by order ID
- `GET /api/order/getalldeliverymethodsasync` — Get all available delivery methods

### Payments
- `POST /api/payment/createorupdatepaymentintent` — Create or update Stripe payment intent
- `POST /api/payment/webhook` — Stripe webhook endpoint for payment events


> For a full list and details, use the Swagger UI.

## Usage
- Use the Swagger UI to explore and test API endpoints.
- Register as a user, browse products, add items to the cart, and place orders.
- Admin users can manage products and orders via the API.
- Payments are processed securely via Stripe.

## Testing
- Unit and integration tests can be added using xUnit or NUnit.
- To run tests (if available):
  ```bash
  dotnet test
  ```

## Deployment
- Update connection strings and environment variables for production.
- Use `dotnet publish` to build and deploy the application.
- Configure your web server (IIS, Nginx, Apache) to serve the published files.
- Ensure SQL Server, Redis, and Stripe are accessible from your deployment environment.

## Architecture Overview
- **Repository Pattern:** Abstracts data access logic for maintainability and testability.
- **Specification Pattern:** Enables flexible and reusable query logic.
- **Unit of Work:** Manages transactions and repository instances.
- **DTOs and AutoMapper:** Clean separation between data models and API contracts.
- **Middleware:** Handles exceptions and cross-cutting concerns.
- **Seeding:** Ensures initial data and admin users are available on first run.
- **Stripe Integration:** Handles payment processing securely and efficiently.

## Contributing
1. Fork the repository
2. Create your feature branch (`git checkout -b feature/YourFeature`)
3. Commit your changes (`git commit -am 'Add new feature'`)
4. Push to the branch (`git push origin feature/YourFeature`)
5. Open a pull request

## License
This project is licensed under the MIT License.