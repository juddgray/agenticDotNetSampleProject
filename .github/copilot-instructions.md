# Enterprise .NET 10 Architecture Constraints

## Language & Framework Mandates
- Always target modern C# asynchronous task structures using clean async/await patterns.
- Explicitly pass a `CancellationToken` through to all Entity Framework and Redis calls.
- Never block threads using `.Result` or `.Wait()`. Always write async execution paths.
- Enforce strict separation of concerns: Web API Controllers -> Infrastructure Layer -> Core Domain.

## Performance Guardrails
- Data access layers must leverage `AsNoTracking()` for read-only database query logic.
- Proactively use database projections to transform models directly into lightweight DTOs.
- Multi-threaded shared caches must use `SemaphoreSlim` to guarantee thread safety and prevent cache stampedes.