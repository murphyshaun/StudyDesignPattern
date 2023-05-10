const serviceLogistics = (cargoVolume) => {
    switch (cargoVolume) {
        case '10':
            return {
                name: 'Truck 10',
                door: 6,
                price: 100
            }
        case '20':
            return {
                name: 'Truck 20',
                door: 16,
                price: 1000
            }
        default:
    }
}