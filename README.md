# Vehicle Calculate Toll System 

Intermediate level task for practicing pattern matching, object-oriented programming, abstract classes, [Template Method pattern](https://refactoring.guru/design-patterns/template-method).

Estimated time to complete the task - 1h.

The task requires .NET 8 SDK installed.

## Task Details

- Implement a vehicle type hierarchy for pricing and toll calculation to manage vehicle traffic in a major metropolitan area during peak hours.
   ![](/Vehicle_hierarchy.png)
- Pricing depends on     
   - the vehicle type;
   - the number of passengers for the passenger vehicles or weight category for trucks; 
   - the time and the week day of the traffic.

   <details>
   <summary>

   The basic toll calculations.

   </summary>
   
   The base toll calculations relies only on the vehicle type.    

   _For example:_

   | Vehicle | Basic toll |
   | ------ | ------ |
   | Car | $2.00 |
   | Taxi | $3.50 |
   | Bus | $5.00 |
   | DeliveryTruck | $10.00 | 

   </details>

   <details>
   <summary>

   Adding occupancy pricing.

   </summary>

   The toll adjust for the vehicles to travel depeneds on the passenger count. The movement of vehicles with maximum capacity is encouraged.       
      - taxis without passengers pay some amount extra;   
      - for taxis, the discount depends on the number of passengers;    
      - for buses, the amount of the discount depends on the percentage of filling.      

   **Taxi**

   | Passengers count | Extra/discount |
   | ------ | ------ |
   | 0 | extra $0.50 |
   | 2 | $0.50 discount |
   | 3 and more | $1.00 discount |

   **Bus**

   | Passenger filling in % | Extra or discount |
   | ------ | ------ |
   |  less than 50% | extra $2.00 |
   | more than 90% | $1.00 discount |
   
   The toll adjust for the delivery trucks depends on its weight category: for trucks over a certain weight, an additional fee is charged, otherwise a discount is provided.
   
   **Truck**

   | Weight class | Extra or discount |
   | ------ | ------ |
   | over 5000 lbs | extra $5.00 |
   | under 3000 lbs | $2.00 discount |

   </details>

   <details>
   <summary>

   Adding peak pricing.

   </summary>
   
   Finally, peak hours are added to the pricing. For example, in the morning and evening hours, the tolls are increased. The rule by which the cost is recalculated in this case may depend on the direction of movement (from the city / to the city).

   |   Day	   |     Time   	| Direction |	Premium |
   |-----------|--------------|-----------|----------|
   | Weekday	| morning rush	| inbound	| x 2.00   |
   | Weekday	| morning rush	| outbound	| x 1.00   |
   | Weekday	| daytime	   | inbound	| x 1.50   |
   | Weekday	| daytime	   | outbound	| x 1.50   |
   | Weekday	| evening rush	| inbound	| x 1.00   |
   | Weekday	| evening rush	| outbound	| x 2.00   |
   | Weekday	| overnight	   | inbound	| x 0.75   |
   | Weekday	| overnight	   | outbound	| x 0.75   |
   | Weekend	| morning rush	| inbound	| x 1.00   |
   | Weekend	| morning rush	| outbound	| x 1.00   |
   | Weekend	| daytime	   | inbound	| x 1.00   |
   | Weekend	| daytime	   | outbound	| x 1.00   |
   | Weekend	| evening rush	| inbound	| x 1.00   |
   | Weekend	| evening rush	| outbound	| x 1.00   |
   | Weekend	| overnight	   | inbound	| x 1.00   |
   | Weekend	| overnight	   | outbound	| x 1.00   |

   </details>
