using Microsoft.AspNetCore.Components;

namespace Test1.Shared; 

public partial class MainLayout {
    [Parameter]
    public string? LeftSide { get; set; }
}
