class ServiceLogistics {
    constructor(door = 6, price = 100, name = "Truck10") {
        this.door = door
        this.price = price
        this.name = name
    }

    static getTransport = (cargoVolume) => {
        switch (cargoVolume) {
            case '10':
                return new ServiceLogistics()

            case '20':
                return new ServiceLogistics(16, 1000, 'Truck 20')
        }
    }
}

console.log(ServiceLogistics.getTransport('10'))

//sau này nếu thêm vận trải biển
//và viêt thêm code ở function getTransport
//vi phạm nguyên tắc đóng mở trong SOLID
//=> Factory Method Pattern