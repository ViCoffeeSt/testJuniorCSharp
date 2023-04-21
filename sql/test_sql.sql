SELECT products_name, categories_name

FROM products

LEFT JOIN product_categories ON products.id = product_categories.product_id
