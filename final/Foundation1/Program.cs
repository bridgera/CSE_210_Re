using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
    // VIDEO 1
        Video video1 = new Video("How to make a safe 4D House", "RAMDER+", 348);
        // Comments
        video1.AddComment("vii-ka", "The reason this works is if you don't make the filled in houses then you can use Shift + Q/E to go right through the house, & the spiders can do this too. & if you use the scroll wheel you can see the walls are missing.");
        video1.AddComment("sapphia527", "I feel like it would be helpful to have a compass in your offhand for tutorials since it's hard for a viewer to tell which direction you're moving in or what way your looking without it.");
        video1.AddComment("airplanes_aren.t_real", "Imagine when they add redstone to this");
        // Display
        video1.Display();

    // VIDEO 2
        Video video2 = new Video(" Octree Visualisation Engine ", "Ratty", 55);
        // Comments
        video2.AddComment("GabeRundlett", "This is epic. I didn't expect the spaceship to be part of the same acceleration structure as the world, and would have guessed that they were rendered separately. I'm surprised how fast your octree can update. Keep up the good work!");
        video2.AddComment("jed0378", "How did you manager to make tree traversing so fast on the GPU? To me it seems like magic trying to make recursive and that isn't predictable work on the GPU so this is definitely looks like magic to me. Super awesome stuff!");
        video2.AddComment("SeanStClair-cr9jl", "This looks so exceptionally cool on its own that it should definitely be developed into its own project. Like, the phantom black-and-white visuals themselves. This looks amazing and so unique! Obviously I'm imagining a super amped-up moon lander.");
        // Display
        video2.Display();  

    // VIDEO 3
        Video video3 = new Video("HOLLOW KNIGHT be like", "AlzAnimations", 163);
        // Comments
        video3.AddComment("bagofleavesp831", "Dude i EXPLODED at the end lmao, thanks for making my day");
        video3.AddComment("mu4784","Couldn't be more perfectly summarized in two and a half minutes.");
        video3.AddComment("kmpartist","Lmao I love the environment paintings and had some lovely pacing in the shots, pale ore level comedy!");
        video3.AddComment("rabbit7261","That Radiance jump scare at the end had me dying");
        video3.AddComment("gimmer6014","Mate this might be the most accurate video I have seen about the game. The animation is also fantastic, it has a sense of realism, while also retaining a cartooni look. Well done!");
        // Display
        video3.Display();  
    }
}