# Observer Pattern

## Intent

Define a one-to-many dependency so that when one object changes state,
all its dependents are notified automatically.

---

## Problem

Tightly coupling objects that depend on each other leads to rigid systems.

---

## Solution

The Observer pattern:
- Enables event-driven communication
- Decouples publishers from subscribers
- Supports reactive systems

---

## When to Use

- Event systems
- Notifications
- UI updates
- Real-time data propagation

---

## Implementations in This Repo

- **C#**: EventHandler-based observers
- **PHP**: User notification system
- **Node.js**: EventEmitter
- **JavaScript**: State change subscriptions
- **Kotlin**: LiveData
- **React**: Context + hooks
