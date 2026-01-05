# Dependency Injection (DI) Pattern

## Intent

Dependency Injection is a design pattern that **decouples the creation of a class’s dependencies** from the class itself.
It allows an object to receive its dependencies from an external source rather than instantiating them internally.

---

## Problem

Hardcoding dependencies inside a class leads to:

- Tight coupling
- Difficulty in testing
- Inflexibility to change implementations

---

## Solution

Use Dependency Injection to **inject dependencies** via:

- **Constructor Injection**: Dependencies passed through the constructor
- **Setter Injection**: Dependencies passed via setter methods
- **Interface Injection**: Class exposes an interface for setting dependencies

This separates object creation from business logic and enables **inversion of control** (IoC).

---

## When to Use

- Classes with external dependencies (services, repositories, API clients)
- Applications requiring high testability
- Systems where implementations may change (mocking or swapping implementations)

---

## Implementations in This Repo

- **C#**: Injecting a `ILogger` or `IDataRepository` into a service class
- **PHP**: Injecting a `DatabaseConnection` or `Mailer` into controllers
- **Node.js**: Injecting services into Express route handlers
- **JavaScript**: Injecting dependencies into modules using ES6 imports or constructor patterns
- **Kotlin**: Injecting repositories into ViewModels in Android
- **React**: Using Context API or custom hooks to inject global services or state
