REVOKE ALL ON SCHEMA config FROM public;

GRANT USAGE ON SCHEMA config TO mix_erp;

ALTER DEFAULT PRIVILEGES IN SCHEMA config GRANT SELECT, INSERT, UPDATE, DELETE ON TABLES TO mix_erp;

ALTER DEFAULT PRIVILEGES IN SCHEMA config GRANT ALL ON SEQUENCES TO mix_erp;

ALTER DEFAULT PRIVILEGES IN SCHEMA config GRANT EXECUTE ON FUNCTIONS TO mix_erp;

GRANT ALL PRIVILEGES ON SCHEMA config TO mix_erp;
GRANT SELECT, INSERT, UPDATE, DELETE ON ALL TABLES IN SCHEMA config TO mix_erp;
GRANT ALL PRIVILEGES ON ALL SEQUENCES IN SCHEMA config TO mix_erp;
GRANT EXECUTE ON ALL FUNCTIONS IN SCHEMA config TO mix_erp;