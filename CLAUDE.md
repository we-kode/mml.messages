# Messages

## Purpose

Small .NET 10 class library containing the event contracts exchanged by MML backend services through RabbitMQ. It has no web host and should remain transport/domain-contract focused.

## Code map

- `Events/` contains message types.
- `Events/Interfaces/` contains shared event interfaces and contract abstractions.
- `Messages.csproj` defines the package identity and target framework.

## Local commands

```bash
dotnet restore Messages.sln
dotnet build Messages.sln
dotnet test Messages.sln
```

Treat public event names, namespaces, properties, nullability, and serialized representations as compatibility-sensitive. Prefer additive changes; coordinate breaking changes with every producer and consumer in Identity and Media. Do not add service behavior or infrastructure dependencies here.

Update `mml.project/docs/architecture.mdx` when event-driven boundaries or message contracts change, and update service documentation when producers or consumers change.
