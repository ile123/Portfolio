package com.petstore.admin.shoppingcart;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.security.core.Authentication;
import org.springframework.security.core.context.SecurityContextHolder;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RestController;

import com.petstore.admin.customer.CustomerService;
import com.petstore.common.entity.Customer;


@RestController
public class CartItemController {
	@Autowired
	private CartItemService cartService;
	
	@Autowired
	private CustomerService customerService;
	
	@GetMapping("/cart/buy/{productId}")
	public void addProductToCart(@PathVariable(name = "productId") Integer productId) {
		Authentication auth = SecurityContextHolder.getContext().getAuthentication();
		Customer customer = customerService.findByEmail(auth.getName());
		cartService.addProduct(productId, customer);
	}
	
	
}