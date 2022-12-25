<p align="center">
  <h2 align="center">Flow Control Inventory System</h2>
</p>

<br>

![](https://i.imgur.com/waxVImv.png)

<p align="center"> A personal project about 'Inventory System'.</p>
<p align="center">This project will use c# and a database('to be picked yet..')</p>

![](https://i.imgur.com/waxVImv.png)

## <center/>Development

Clone the repository, and start the application

```bash
git clone https://github.com/HstericaL/Flow-Control-Inventory-System.git
```
![](https://i.imgur.com/waxVImv.png)

## <center/>Information

![](https://i.imgur.com/waxVImv.png)
## <center/>Database Information

Here are the table, datatype and variabel names:

<table>

<tr><td>

| **inventory** |  |
| ----------- | ----------- |
| **product_id** | ***int*** |
| product_name | varchar |
| product_description | text |
| product_category | varchar |
| product_quantity | int |
| product_price | decimal(10,2) |
| product_added | date |

| **category** |  |
| ----------- | ----------- |
| **category_id** | ***int*** |
| category_name | varchar |



| **orders** |  |
| ----------- | ----------- |
| **order_id** | ***int*** |
| customer_id | int |
| order_date | date |
| shipping_address | varchar |
| total_cost | decimal(10,2) |

| **customers** |  |
| ----------- | ----------- |
| **customer_id** | ***int*** |
| customer_name | varchar |
| contact_info | varchar |
| billing_address | varchar |

</tr></td>
</table>



