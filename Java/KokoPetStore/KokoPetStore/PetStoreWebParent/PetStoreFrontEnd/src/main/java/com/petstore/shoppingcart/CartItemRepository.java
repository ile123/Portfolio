package com.petstore.shoppingcart;

import java.util.List;

import org.springframework.data.jpa.repository.Modifying;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.PagingAndSortingRepository;

import com.petstore.common.entity.CartItem;

public interface CartItemRepository extends PagingAndSortingRepository<CartItem, Integer> {
	
	@Query("SELECT x FROM CartItem x WHERE x.customer.id = ?1")
	public List<CartItem> findByCustomer(Integer customerId);
	@Query("SELECT x FROM CartItem x WHERE x.product.id = ?1")
	public List<CartItem> findByProduct(Integer productId);
	@Query("SELECT x FROM CartItem x WHERE x.customer.id = ?1 AND x.product.id = ?2")
	public CartItem findByCustomerAndProduct(Integer customerId, Integer productId);
	
	@Modifying
	@Query("DELETE FROM CartItem x WHERE x.customer.id = ?1 AND x.product.id = ?2")
	public void deleteByCustomerAndProduct(Integer customerId, Integer productId);
	
}
