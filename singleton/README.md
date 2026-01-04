# Singleton Pattern

## Intent

Ensure that a class has **only one instance** and provide a **global point of access**
to that instance.

---

## Problem

Some resources should be shared across the entire application, such as:
- Application configuration
- Logging services
- Database connections

Creating multiple instances can lead to inconsistent state or wasted resources.

---

## Solution

The Singleton pattern:
- Restricts object creation
- Exposes a single, shared instance
- Controls lifecycle and access

---

## When to Use

- When exactly one instance is required
- When global access is needed but controlled
- When managing shared resources

---

## Implementations in This Repo

- **C#**: Application-wide Logger
- **PHP**: Configuration loader
- **Node.js**: Shared configuration module
- **JavaScript**: Simple global state manager
- **Kotlin**: Android app configuration

---

## Notes

⚠ Overuse of Singleton can lead to hidden dependencies and testing difficulties.
Prefer dependency injection when possible.