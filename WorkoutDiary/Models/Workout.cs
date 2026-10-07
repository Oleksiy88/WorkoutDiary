namespace WorkoutDiary.Models;

public class Workout
{
    public int Id { get; set; }

    public string Title { get; set; } = "";

    public DateOnly PerformedOn { get; set; }

    public int DurationMinutes { get; set; }

    public decimal DistanceKilometers { get; set; }

    public int MinHeartRate { get; set; }

    public int MaxHeartRate { get; set; }

    public string? Notes { get; set; }

    public WorkoutStatus Status { get; set; }
}