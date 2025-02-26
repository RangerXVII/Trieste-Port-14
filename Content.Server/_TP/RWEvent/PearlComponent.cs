﻿namespace Content.Server.TP.Event.Components;

using Content.Server.Xenoarchaeology.XenoArtifacts;
using Content.Shared.Construction.Prototypes;
using Robust.Shared.Audio;
using Robust.Shared.Serialization.TypeSerializers.Implementations;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom.Prototype;
using Robust.Shared.Prototypes;

[RegisterComponent]
public sealed partial class PearlComponent : Component
{
    [DataField("pearlMessage")]
    private string PearlMessage = "pearl-message-BASE";

    [DataField("content"), AutoNetworkedField]
    public string Content { get; set; } = "";
}
