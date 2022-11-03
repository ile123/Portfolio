package com.petstore.admin.brand;


import org.springframework.data.domain.Page;
import org.springframework.data.domain.Pageable;
import org.springframework.data.jpa.repository.Modifying;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.PagingAndSortingRepository;
import org.springframework.data.repository.query.Param;
import org.springframework.stereotype.Repository;
import org.springframework.transaction.annotation.Transactional;

import com.petstore.common.entity.Brand;

@Repository
public interface BrandRepository extends PagingAndSortingRepository<Brand, Integer> {
	@Query("SELECT x FROM Brand x WHERE x.name = :name")
	public Brand getBrandByName(@Param("name") String name);
	
	@Query("SELECT x FROM Brand x WHERE x.name LIKE %?1%")
	public Page<Brand> findAll(String keyword, Pageable pageable);
	
	@Transactional
	@Modifying
	@Query("UPDATE Brand x SET x.name = :name WHERE x.Id = :Id")
	public void updateBrand(@Param("name") String name, @Param("Id") Integer Id);
	
	/*
	@Query("SELECT NEW Brand(x.Id, x.name) FROM Brand x ORDER BY x.name ASC")
	public List<Brand> findAll();
	*/
}
