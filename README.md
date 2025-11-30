# Restrict-window-docking-side-using-DockingPreviewHint-event-in-Winforms

This sample shows how to stop docking windows to certain sides of the host form by handling Syncfusion DockingManager's PreviewDockHints event. You can selectively allow or block dock hints (Left, Top, Right, Bottom, Fill/Document) for either the outer edges of the host or inner targets, guiding users to only the positions you want.

## Features
- Allow or block docking to specific sides of the host form (outer dock hints)
- Restrict docking on particular targets inside the layout (inner dock hints)
- Per-control rules based on dragging source and target
- Simple, event-based customization using PreviewDockHintsEventArgs.DockAbility
- Works with standard DockingManager drag-and-dock workflow

## Getting Started
1. Add a DockingManager to your WinForms form and register dockable controls (e.g., panels).
2. Subscribe to the PreviewDockHints event on the DockingManager.
3. In the event handler, set e.DockAbility to the allowed sides based on which control is being dragged over which target.

## Key API
- Event: DockingManager.PreviewDockHints
- Args: Syncfusion.Windows.Forms.Tools.PreviewDockHintsEventArgs
  - DraggingSource: Control being dragged
  - DraggingTarget: Control or host zone under the pointer
  - IsOuterDockHints: True when dock hints at the host form edges are shown
  - DockAbility: Bitwise flags that decide which dock hints are visible
- Enum: Syncfusion.Windows.Forms.Tools.DockAbility (None, Left, Top, Right, Bottom, Fill)

## Tips
- Combine DockAbility flags with bitwise OR to allow more than one side.
- Use IsOuterDockHints to enforce rules at the form edges without affecting inner targets.
- Pair with DockAllow to cancel docking in specific drag scenarios, or DockVisibilityChanging to prevent close/hide actions.

## About this sample
This README focuses on guiding you to selectively limit docking positions so users cannot dock to restricted areas of the host form. Extend the logic to different sources/targets, persist rules, or toggle restrictions based on application state.
