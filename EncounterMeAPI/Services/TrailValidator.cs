using System;
using EncounterMeAPI.Entities;
using FluentValidation;

namespace EncounterMeAPI.Services
{
    public class TrailValidator : AbstractValidator<Trail>
    {
        public TrailValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Length).NotEmpty().GreaterThan(0);
            RuleFor(x => x.StartLocation).NotEmpty();
            RuleFor(x => x.EndLocation).NotEmpty();
            RuleFor(x => x.UploadDate).NotEmpty();
        }
    }
}
