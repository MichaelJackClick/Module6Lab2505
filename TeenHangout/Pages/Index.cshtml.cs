using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TeenHangout.Pages;

public class IndexModel : PageModel
{
    // Array of users
    public User[] Users { get; } =
    [
        new("MusicLover", 15, "Purple"),
        new("GamerGirl", 16, "Red"),
        new("BookwormBen", 15, "Yellow")
    ];

    // Array of posts
    public Post[] Posts { get; } =
    [
        new("GamerGirl", "Anyone want to play online later?", 30),
        new("BookwormBen", "Reading the best book ever!", 15),
        new("MusicLover", "Concert next week! So excited!", 22)
    ];
}
