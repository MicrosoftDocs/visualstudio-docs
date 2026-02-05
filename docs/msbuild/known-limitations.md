# MSB4191: Item metadata in conditions outside of targets (known limitation)

This page documents a **known MSBuild limitation**. MSBuild evaluates a project in phases (most notably **project evaluation** and **target execution**), and some constructs are only supported during target execution. When a construct isn’t supported in the phase where it’s used, MSBuild may emit a specific error code (such as **MSB4191**) or behave differently than expected. Use this page to understand the limitation and apply one of the supported workarounds.

## Applies to

- MSBuild (all versions)

## Summary

Using item metadata syntax in a condition—`%(ItemType.MetadataName)`—is **not supported at project evaluation time** (outside of `Target` execution). If you use it in a project-level `Condition` (for example, in an `ItemGroup` that is not inside a `Target`), MSBuild fails with **MSB4191**.

This is a **known limitation**: `%(...)` metadata references in conditions rely on **batching**, and batching happens only during **target execution**.

## Symptom / error

```text
error MSB4191: The reference to custom metadata "X" at position 1 is not allowed in this condition "'%(Content.X)' == 'abc'".
