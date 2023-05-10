//create service car
class Car {
    constructor({ name = 'Ford Ranger 2023', doors = 4, price = 100, customerInfo = {} }) {
        this.name = name
        this.doors = doors
        this.price = price
        this.customerInfo = customerInfo
    }
}

//create service Logistics
class ServiceLogistics {
    transportClass = Car
    getTransport = (customerInfo) => {
        return new this.transportClass(customerInfo)
    }
}

//order for customer by Car
const carService = new ServiceLogistics();
console.log('car service: ', carService.getTransport({ customerInfo: { name: 'anoystick', cargoVolume: '100kg' } }))

// cach 1
class Truck {
    constructor({ name = 'Container 2023', doors = 14, price = 1600, customerInfo = {} }) {
        this.name = name
        this.doors = doors
        this.price = price
        this.customerInfo = customerInfo
    }
}

carService.transportClass = Truck
console.log('truck service: ', carService.getTransport({ customerInfo: { name: 'truck big', cargoVolume: '1000kg' } }))

//cach 2 *
class TruckService extends ServiceLogistics {
    transportClass = Truck
}

const truckService = new TruckService();
console.log('truck service: ', truckService.getTransport({ customerInfo: { name: 'truck big 1', cargoVolume: '1200kg' } }))