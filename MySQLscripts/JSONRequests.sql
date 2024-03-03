SELECT CONCAT('{',
    '"id":', id,  ', ', 
    '"number":', number, ', ', 
    '"type":', type, ', ', 
    '"lenght":', length, ', ', 
    '"width":', width, ', ', 
    '"height":', height, ', ',
    '"weight":', weight, ', ',
    '"b_empty":', CAST(b_empty as UNSIGNED), ', ',
    '"receipt_date":', receipt_date, '"',
    '}') AS json_data 
    FROM containers;


SELECT CONCAT('{',
    '"id":', id,  ', ', 
    '"start_date":', start_date, ', ', 
    '"end_date":', end_date, ', ', 
    '"operation_type":', operation_type, ', ', 
    '"operator_fullname":', operator_fullname, ', ', 
    '"inspection_place":', inspection_place, '"',
    '}') AS json_data 
    FROM operations
    WHERE container_id='1';
