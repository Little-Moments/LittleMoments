using System.Text.Json;
using Microsoft.AspNetCore.Components;
using Radzen;
using LittleMoments.Data;

namespace LittleMoments.Components.Kids.Shared;

public partial class KidForm : ComponentBase
{
    bool popup;

    Kid kid = new Kid { Name = string.Empty };

    void OnSubmit(Kid kid)
    {
    }

    void OnInvalidSubmit(FormInvalidSubmitEventArgs args)
    {
    }
}