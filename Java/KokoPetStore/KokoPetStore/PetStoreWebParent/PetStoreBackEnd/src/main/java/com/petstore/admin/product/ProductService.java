package com.petstore.admin.product;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.data.domain.Page;
import org.springframework.data.domain.PageRequest;
import org.springframework.data.domain.Pageable;
import org.springframework.data.domain.Sort;
import org.springframework.stereotype.Service;

import com.petstore.admin.shoppingcart.CartItemRepository;
import com.petstore.common.entity.CartItem;
import com.petstore.common.entity.Product;

@Service
public class ProductService {
	@Autowired
	private ProductRepository repo;
	
	@Autowired
	private CartItemRepository cartRepo;
	
	public static final int ProductsPerPage = 5;
	
	public List<Product> GetAllProducts(){
		return (List<Product>) repo.findAll();
	}
	
	public void save(Product product) {
		if(!isProductNameUnique(product.getName())) {
			return;
			}
		repo.save(product);
	}
	
	public void update(Product product) {
		/*
		List<CartItem> customers = cartRepo.findByProduct(product.getId());
		for (CartItem item : customers) {
			item.setProduct(product);
		}
		product.setCostumers(customers);
		*/
		repo.save(product);
	}
	
	public void delete(Integer id) {
		if(repo.findById(id).get() == null) {
			return;
		}
		repo.deleteById(id);
	}
	
	public boolean isProductNameUnique(String name) {
		Product productByName = repo.getProductByName(name);
		return productByName == null;
	}
	
	public Product get(Integer id) {
		return repo.findById(id).get();
	}
	
	public Page<Product> listByPage(int pageNum, String sortField, String sortDir, String keyword){
		Sort sort = Sort.by(sortField);
		sort = sortDir.equals("asc") ? sort.ascending() : sort.descending();
		Pageable pageable = PageRequest.of(pageNum - 1, ProductsPerPage, sort);
		
		if(keyword != null) {
			return repo.findAll(keyword,pageable);
		}
		
		return repo.findAll(pageable);
	}
}
