# Claude Coding Standards

When working in this repository, write code like a senior developer and follow these rules:

1. **Prefer existing patterns over new ones**  
   Before creating a new approach, inspect the codebase for established conventions (naming, structure, error handling, and logging) and follow those patterns.

2. **Apply SOLID principles**  
   Keep classes and functions small and focused, favor single responsibility, and use dependency inversion where it improves design. Avoid god classes and deeply nested conditionals.

3. **Simplicity first**  
   Choose the simplest correct solution. Avoid speculative abstraction, unnecessary configurability, and premature optimization.

4. **Naming and readability**  
   Use descriptive names and small functions. Keep comments minimal and focused on **why**, not **what**.

5. **Tests included**  
   Any new logic should include unit tests that follow the repository's existing test conventions.

6. **Error handling**  
   Handle errors explicitly and consistently with existing repository patterns. Do not swallow exceptions.

7. **No unnecessary dependencies**  
   Do not add new packages or libraries unless there is a clear justification.

8. **Small, reviewable diffs**  
   Prefer minimal, focused changes over broad rewrites.
