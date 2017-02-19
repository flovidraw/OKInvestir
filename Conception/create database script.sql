USE OKInvestir;

DROP TABLE IF EXISTS
  order_odr;

DROP TABLE IF EXISTS
  simulation_sml;

DROP TABLE IF EXISTS
  account_act;

DROP TABLE IF EXISTS
  client_clt;

DROP TABLE IF EXISTS
  bought_product_bpt;

DROP TABLE IF EXISTS
  sill_interest_dict_sid;

DROP TABLE IF EXISTS
  time_interest_dict_tid;

DROP TABLE IF EXISTS
  product_pdt;

CREATE TABLE IF NOT EXISTS product_pdt(
    pdt_id INT(10) NOT NULL AUTO_INCREMENT PRIMARY KEY,
    pdt_name VARCHAR(30) NOT NULL,
    pdt_description VARCHAR(1000) NOT NULL,
    pdt_status INT(1) NOT NULL
);

CREATE TABLE IF NOT EXISTS sill_interest_dict_sid(
    sid_id INT(10) NOT NULL AUTO_INCREMENT PRIMARY KEY,
    sid_pdt_id INT(10) NOT NULL,
    sid_sill FLOAT(15, 2) NOT NULL,
    sid_interest FLOAT(5, 2) NOT NULL,
    FOREIGN KEY(sid_pdt_id) REFERENCES product_pdt(pdt_id) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE IF NOT EXISTS time_interest_dict_tid(
    tid_id INT(10) NOT NULL AUTO_INCREMENT PRIMARY KEY,
    tid_pdt_id INT(10) NOT NULL,
    tid_sill FLOAT(15, 2) NOT NULL,    # number of month
    tid_interest FLOAT(5, 2) NOT NULL,
    FOREIGN KEY(tid_pdt_id) REFERENCES product_pdt(pdt_id) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE IF NOT EXISTS bought_product_bpt(
    bpt_id INT(10) NOT NULL AUTO_INCREMENT PRIMARY KEY,
    bpt_pdt_id INT(10) NOT NULL,
    bpt_final_interest FLOAT(5, 2) NOT NULL,
    bpt_start_date DATETIME NOT NULL,
    bpt_end_date DATETIME NOT NULL,
    bpt_status INT(1) NOT NULL,
    FOREIGN KEY(bpt_pdt_id) REFERENCES product_pdt(pdt_id) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE IF NOT EXISTS client_clt(
    clt_id INT(10) NOT NULL AUTO_INCREMENT PRIMARY KEY,
    clt_first_name VARCHAR(30) NOT NULL,
    clt_last_name VARCHAR(30) NOT NULL
);

CREATE TABLE IF NOT EXISTS account_act(
    act_id INT(10) NOT NULL AUTO_INCREMENT PRIMARY KEY,
    act_balance FLOAT(15, 2) NOT NULL,
    act_status INT(1) NOT NULL,
	act_clt_id INT(10) NOT NULL,
    FOREIGN KEY(act_clt_id) REFERENCES client_clt(clt_id) ON DELETE CASCADE ON UPDATE CASCADE
);


CREATE TABLE IF NOT EXISTS simulation_sml(
    sml_id INT(10) NOT NULL AUTO_INCREMENT PRIMARY KEY,
    sml_pdt_id INT(10) NOT NULL,
    sml_price FLOAT(15,2) NOT NULL,
    sml_start_date DATETIME NOT NULL,
    sml_end_date DATETIME NOT NULL,
    sml_clt_id INT(10) NOT NULL,
    FOREIGN KEY(sml_pdt_id) REFERENCES product_pdt(pdt_id) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY(sml_clt_id) REFERENCES client_clt(clt_id) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE IF NOT EXISTS order_odr(
    odr_id INT(10) NOT NULL AUTO_INCREMENT PRIMARY KEY,
    odr_clt_id INT(10) NOT NULL,
    odr_bpt_id INT(10) NOT NULL,
    odr_status INT(1) NOT NULL,
    odr_new_odr_id INT(10) NOT NULL,
    odr_time DATETIME NOT NULL,
    FOREIGN KEY(odr_clt_id) REFERENCES client_clt(clt_id) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY(odr_bpt_id) REFERENCES bought_product_bpt(bpt_id) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY(odr_new_odr_id) REFERENCES order_odr(odr_id) ON DELETE CASCADE ON UPDATE CASCADE
);