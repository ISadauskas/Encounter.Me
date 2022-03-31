using EncounterMeAPI.Entities;

interface IStatisticsService
{
    public WalkStatistics CalculateStatistics(Trail trail, int time, double weight);
}

