# Agentic .NET Core Multi-Tenant API (Visual Studio 2026 & Copilot Agent Mode)

[![.NET 10](https://shields.io)](https://microsoft.com)
[![License: MIT](https://shields.io)](LICENSE)
[![Copilot Verified](https://shields.io)]()

> **Stop using AI as a glorified autocomplete tool. Welcome to the era of Vibe Coding at an architectural level.**

This repository serves as a production-grade, enterprise blueprint for a **Multi-Tenant REST API with Distributed Redis Caching**. The entire solution was architected, scaffolded, audited, and hardened using **Visual Studio 2026** and **GitHub Copilot Agent Mode** operating under strict natural-language constraint boundaries.

---

## 🎓 Master the Full Workflow (97% Instructor Discount)

This repository contains the completed production code. If you want to learn how to orchestrate autonomous agents to build, code-review, security-audit, and deploy this entire system from scratch in under 30 seconds, join the complete masterclass:

👉 **[CLICK HERE to Enroll in the Complete Agentic .NET Course (Maximum Discount Applied)](#)** 
*(Using this link directly supports the creator by routing 97% of the revenue share to the instructor instead of the generic Udemy marketplace pool).*

---

## 🏗️ System Architecture & Features

This system demonstrates a modern, high-throughput backend designed to enforce strict tenant isolation while staying optimized under heavy traffic spikes.

[ Client Request ]
│
▼
[ Custom Middleware Filter ] ──► (Validates X-Tenant-ID Header)
│
▼
[ Distributed Cache Layer ] ──► (Thread-Safe Redis Cache-Aside via SemaphoreSlim)
│
▼
[ Isolated DB Context Tier ] ──► (Entity Framework Core Tenant Query Filters)

*   **Autonomous Multi-File Scaffolding:** Generated via `@architect` and `@plan` roles without manual boilerplate copying.
*   **Strict Tenant Isolation:** Active runtime HTTP header interception and scoped request mapping to secure tenant databases.
*   **Thread-Safe Cache-Aside Pipeline:** Integrated Redis caching backed by `SemaphoreSlim` to completely eliminate cache stampede vulnerabilities.
*   **Agentic Quality Gate:** Custom linter and Roslyn configurations injected into `.github/copilot-instructions.md` to prevent anti-patterns (e.g., blocking `.Result` calls).
*   **Automated Security Profiles:** Hardened against OWASP Top 10 vulnerabilities with automated secret scrubbing and runtime configuration mapping.

---

## ⚙️ The Crown Jewel: `.github/copilot-instructions.md`

To force the Copilot engine to write compliant enterprise C# on its very first attempt, this project utilizes a root-level context instruction file. **You can fork this file to use in your own professional projects:**

```markdown
# Enterprise .NET Core Architecture Constraints

## Language & Framework Mandates
- Always target C# 14 asynchronous task structures.
- Enforce strict separation of concerns: Web API -> Business Logic -> Data Access.
- Never write blocking synchronous code (`.Result` or `.Wait()`). Use `await`.

## Concurrency & Performance
- All database queries must accept and pass through a `CancellationToken`.
- Database write projections must be transformed directly into lightweight DTOs.
- Multi-threaded shared caches must use `SemaphoreSlim` to guarantee thread safety.

## Error Handling & Security
- Never expose internal database stack traces to the public HTTP interface.
- Intercept errors using global middleware filters; return standard RFC 7807 payloads.
- Intercept and block hardcoded connection strings or passwords instantly.
```

---

## 🚀 Getting Started

### Prerequisites
*   [.NET 10 SDK](https://microsoft.com)
*   [Visual Studio 2026 (Preview 2 or higher)](https://microsoft.com)
*   [Docker Desktop](https://docker.com) (For local Redis running instance)
*   GitHub Copilot Pro / Business Subscription

### Installation & Spin Up
1. Clone the repository to your local directory:
   ```bash
   git clone github.com
   cd agentic-dotnet-api
   ```

2. Spin up the localized infra container suite (SQL Server & Redis Instance):
   ```bash
   docker-compose up -d
   ```

3. Open the workspace inside **Visual Studio 2026**, summon your agent console via your shortcut hotkey, and run an initial validation audit:
   ```text
   @workspace #check Verify tenant middleware routing and run the execution pipeline.
   ```

4. Launch the API locally:
   ```bash
   dotnet run --project src/AgenticApi.Web
   ```

---

## 📊 Course Curriculum Outline

If you are following along via the video masterclass, here is our 5-module developmental sprint:
*   **Module 1:** The Modern AI Workspace & Global JSON Performance Profiles
*   **Module 2:** Agentic Peer-Programming & Autonomous Structural Scaffolding
*   **Module 3:** Asynchronous Web API Development & Concurrency Redis Locks
*   **Module 4:** Tool-Calling Agentic Code Reviews & Automated Pull Request Summaries
*   **Module 5:** Generative xUnit Testing, OWASP Security Audits, & Natural-Language DevOps

---

## 📄 License
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for deep details.

---

## 👥 Connect & Support
*   Have a bug or a missing framework update to report? Open an **Issue** or submit a **Pull Request**.
*   Loved the codebase? **Star this repository** to help other .NET developers transition to agentic workflows!
*   Ready to master this entirely? **[Enroll in the video course today](#).**
________________________________________
💡 Why This GitHub Repo Converts Casual Browsers to Buyers
1.	The Code is Real: High-quality developers search GitHub for solutions to complex problems like "Redis cache stampedes" or "multi-tenant .NET API setups". Finding a complete repo builds instant trust.
2.	The "Secret Sauce" is Free: Giving away the .github/copilot-instructions.md file acts as the ultimate value bomb. It proves you know how to control AI agents, which makes developers want to buy the course to see how you leverage it.
3.	Frictionless Funnel: The link explicitly tells the student that using it helps you out by bypassing Udemy's high commissions, which tech communities (like Reddit or GitHub developers) happily support when receiving value.
To finalize your course product ecosystem, let me know:
•	Would you like me to write a 3-stage launch email sequence to pitch this to your existing networks or social followers?
•	Or should we draft a Reddit text-post value blast for communities like r/dotnet to drive the initial wave of traffic to this GitHub repo?


