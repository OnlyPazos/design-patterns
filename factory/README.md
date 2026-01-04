# Factory Method Pattern

## Intent

Define an interface for creating an object,
but let subclasses decide which class to instantiate.

---

## Problem

Direct object creation tightly couples your code to concrete classes,
making it harder to extend or modify behavior.

---

## Solution

The Factory Method pattern:
- Encapsulates object creation
- Promotes loose coupling
- Makes systems easier to extend

---

## When to Use

- When object creation logic becomes complex
- When multiple implementations share a common interface
- When adding new types should not affect existing code

---

## Implementations in This Repo

- **C#**: Notification factory (Email, SMS)
- **PHP**: Payment gateway factory
- **Node.js**: Logger factory
- **JavaScript**: Chart factory
- **Kotlin**: Fragment/Activity factory
