﻿
namespace BuilderPattern.Model
{
    public interface ICarBuilder
    {
        CarBuilder AddWheels(int numberOfWheels);
        CarBuilder AddSeatBelts(SeatBelt seatBelt);
        CarBuilder Paint(string color);
        CarBuilder AddWindscreen(Windscreen windscreen);
        CarBuilder AddEngine(Engine engine);

        Car Build();
    }
}
