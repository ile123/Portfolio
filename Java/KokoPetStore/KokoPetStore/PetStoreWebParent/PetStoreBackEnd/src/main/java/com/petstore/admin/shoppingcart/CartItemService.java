package com.petstore.admin.shoppingcart;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.petstore.common.entity.Customer;
import com.petstore.common.entity.Product;
import com.petstore.common.entity.CartItem;

@Service
public class CartItemService {
	
	@Autowired
	private CartItemRepository repo;
	
	public void addProduct(Integer productId, Customer customer) {
		Product product = new Product(productId);
		CartItem cartItem = new CartItem(customer,product);
		repo.save(cartItem);
	}
}
