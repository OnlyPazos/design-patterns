# Decorator Pattern

## Intent

Attach additional responsibilities to an object dynamically
without modifying its structure.

---

## Problem

Subclassing for every variation leads to class explosion.

---

## Solution

The Decorator pattern:
- Wraps objects
- Adds behavior at runtime
- Preserves the original interface

---

## When to Use

- Cross-cutting concerns (logging, caching)
- Middleware systems
- UI component enhancement

---

## Implementations in This Repo

- **C#**: Cached logger
- **PHP**: HTTP middleware
- **Node.js**: Express middleware
- **JavaScript**: Function decorators
- **Kotlin**: UI wrappers
- **React**: Higher-Order Components
