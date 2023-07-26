using System.Numerics;
using JetBrains.Annotations;
using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface;
using Robust.Client.UserInterface.XAML;
using Robust.Shared.Animations;
using Robust.Shared.Timing;

namespace Content.Client.UserInterface.Controls;

[GenerateTypedNameReferences]
public sealed partial class RadialItem : Control
{
    [Animatable] public Vector2 Offset { get; set; }
    public string? Content { get; set; }

    public string Texture
    {
        set => Controller.TexturePath = value;
    }

    public byte Opacity
    {
        get => Controller.Modulate.AByte;
        set => Controller.Modulate = new Color(255, 255, 255, value);
    }

    public string? Tooltip
    {
        set => Controller.ToolTip = value;
        get => Controller.ToolTip;
    }

    public float? TooltipDelay
    {
        set => Controller.TooltipDelay = value;
        get => Controller.TooltipDelay;
    }

    [Animatable]
    public Vector2 ButtonSize
    {
        get => this.Size;
        set => this.SetSize = value;
    }

    public RadialItem()
    {
        RobustXamlLoader.Load(this);
        Offset = Vector2.Zero;
    }
}
