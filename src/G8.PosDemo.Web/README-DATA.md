# POS Data Layer Notes

This project has started its first data-layer step.

## Current state
- EF Core added
- SQLite wired for local development
- `PosDbContext` created
- Initial entity set created:
  - ProductCategoryEntity
  - ProductEntity
  - OrderEntity
  - OrderItemEntity
  - CustomerEntity
- Seed data configured for product categories and sample products
- App startup now runs database migration automatically

## Why SQLite first?
SQLite is being used as a low-friction local development step before moving to PostgreSQL.
This lets the project establish:
- entity shapes
- DbContext
- migration flow
- seed behavior

Then later the provider can be changed to PostgreSQL with much less churn.

## Planned next step
- Create first EF migration
- Move product/admin pages off hardcoded in-component data and onto DbContext-backed queries
- Then prepare PostgreSQL provider transition
