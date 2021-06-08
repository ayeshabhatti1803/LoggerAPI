# Varaani C# coding challenge - intermediate

## What is it?

Varaani coding challenge is a part of Varaani's recruitment process. You are requested to demonstrate your coding
skills by implementing a small piece of software. You can do it without our supervision at your own pace, and you're
allowed to use any online or offline material to help you. You are, however, not allowed to ask for help from a person,
or share this challenge with anyone else.

Please comment the code adequately and try to justify your design decisions. Even without a comment we do know that
`a = 3` sets variable `a` to value `3`, but we don't know e.g. a corner case that you thought of, but didn't handle,
how you think your code could be improved, or why you decided to use a certain data structure.

But don't take this too seriously. We are looking for a human being that is able to write some code, not a Superwoman
or a Superman. It is also very well possible that we have made a mistake with this assignment, and we appreciate
any feedback.

## Task

Implement an in-memory logging service that allows you to retrieve the entries in a specified date range.
Unlike a real-world logging service, it shouldn't persist the log entries on disk, otherwise care about
running out of memory, or accept them via any other means than local method calls. But otherwise imagine that it's
a service that accepts log entries from e.g. 10 servers.

The API to implement is documented in `logger/Logger.cs`

## Constraints

* Your app must run with .NET Core SDK 3.1.x
* You can use any external libraries if they make the code more clear, faster, or better in some sense

## Testing

We have our own set of unit tests that we'll run against your code. But we would like you to make your own set of
unit tests. There is a test skeleton in `test-logger/LoggerTest.cs`.
You can run the tests: `dotnet test test-logger\test-logger.csproj`.

## Returning the challenge

Commit your progress in the git repository in increments that make sense to you. If your way of committing is making
a big one with everything in it (we call it a Kekkonen), so be it, but we may not be as happy with the answer.
Use `git bundle` command to make an e-mailable package out of your code and send it back to us.
