﻿using FluentValidation;

namespace InvenTrackCore.Application.UseCases.Inventory.Commands.CreateCommand;

public class CreateInventoryValidation : AbstractValidator<CreateInventoryCommand>
{
    public CreateInventoryValidation()
    {
        RuleFor(x => x.Brand)
            .NotNull().WithMessage("La Marca no puede ser nulo.")
            .NotEmpty().WithMessage("La Marca no puede ser vacío.")
            .MinimumLength(1).WithMessage("La Marca debe de tener como minimo 1 caracter.")
            .MaximumLength(100).WithMessage("La Marca debe de tener un máximo de 100 caracteres");
        RuleFor(x => x.Series)
            .NotNull().WithMessage("La Serie no puede ser nulo.")
            .NotEmpty().WithMessage("La Serie no puede ser vacío.")
            .MinimumLength(1).WithMessage("La Serie debe de tener como minimo 1 caracter.");
        RuleFor(x => x.Model)
            .NotNull().WithMessage("El Modelo no puede ser nulo.")
            .NotEmpty().WithMessage("El Modelo no puede ser vacío.")
            .MinimumLength(1).WithMessage("El Modelo debe de tener como minimo 1 caracter.")
            .MaximumLength(200).WithMessage("El Modelo debe de tener un máximo de 200 caracteres");
    }
}