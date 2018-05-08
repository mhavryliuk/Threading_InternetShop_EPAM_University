## :shopping_cart: Internet Shop (Threading)
 
You are manager of internet shop. There is a counter of orders.  
It increases when client perform an order. You have two categories of clients (VIP and ordinary ones).  
When VIP or ordinary client performs the order the counter or orders is increased.  

**Write the next program:**  
Client class has an event increase the order number. Also client has a property is he VIP or no.  
There is common counter of orders in internet shop.  
You have 10 seconds to calculate number of orders. During this 10 seconds you randomly create clients of both types.  
Every client works in own independent thread. (The tip VIP clients are executed in thread with high priorities.)  
Each client makes an order when he creates an order the counter of orders is increased.  
When 10 seconds will pass, represent number of orders and number of VIP clients and ordinary ones.

<hr/>

Вы менеджер интернет-магазина, у которого есть счетчик заказов.  
У вас есть две категории клиентов (VIP и обычные).  
Когда VIP или обычный клиент выполняет заказ, счетчик заказов увеличивается.

**Напишите следующую программу:**  
В классе клиента число событий увеличивается. Также у клиента есть свойство, он VIP или нет.  
У вас есть 10 секунд, чтобы рассчитать количество заказов.  
В течение этих 10 секунд вы произвольно создаете клиентов обоих типов.  
Каждый клиент работает в собственном независимом потоке (VIP клиенты выполняются в потоке с высокими приоритетами). Когда клиент делает заказ, счетчик заказов увеличивается.  
Когда пройдет 10 секунд, сообщите количество заказов и количество клиентов в разрезе VIP / обычный.
