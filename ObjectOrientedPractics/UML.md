classDiagram
    direction TB

    class OrderStatus {
        <<enumeration>>
        New
        Processing
        Assembly
        Sent
        Delivered
        Returned
        Abandoned
    }

    class Address {
        +int Index
        +string Country
        +string City
        +string Street
        +string Building
        +string Apartment
    }

    class Item {
        +int Id
        +string Name
        +string Info
        +double Cost
    }

    class Cart {
        +List~Item~ Items
        +double Amount
        +Cart()
    }

    class Order {
        +int Id
        +DateTime Date
        +Address Address
        +List~Item~ Items
        +OrderStatus Status
        +double Amount
        +Order(Address address, List~Item~ items)
    }

    class Customer {
        +int Id
        +string Fullname
        +Address Address
        +Cart Cart
        +List~Order~ Orders
        +Customer(string fullname, Address address)
    }

    class Store {
        +List~Item~ Items
        +List~Customer~ Customers
        +Store()
    }

    %% Композиция (закрашенный ромб *--)
    Store *-- Item : 0..*
    Store *-- Customer : 0..*
    Customer *-- Address : 1
    Customer *-- Cart : 1
    Customer *-- Order : 0..*
    Order *-- Address : 1
    Order *-- OrderStatus : 1

    %% Агрегация (незакрашенный ромб o--)
    Cart o-- Item : 0..*
    Order o-- Item : 0..*
