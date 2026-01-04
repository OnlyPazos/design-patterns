# Command Pattern

## Intent

Encapsulate a request as an object,
allowing parameterization and command history.

---

## Problem

Directly invoking actions tightly couples sender and receiver.

---

## Solution

The Command pattern:
- Encapsulates actions
- Enables undo/redo
- Supports task queues

---

## When to Use

- Undo/Redo functionality
- Job queues
- Macro commands

---

## Implementations in This Repo

- **C#**: Text editor undo/redo
- **PHP**: CLI commands
- **Node.js**: Worker tasks
- **JavaScript**: UI actions
- **Kotlin**: User interaction commands
