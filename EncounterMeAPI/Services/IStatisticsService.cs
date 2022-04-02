using EncounterMeAPI.Entities;

public interface IStatisticsService
{
    public WalkStatistics CalculateStatistics(Trail trail, int time, double weight);
}

