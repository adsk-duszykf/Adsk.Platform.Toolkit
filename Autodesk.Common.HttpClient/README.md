# Autodesk HttpClient

This http client is the one used by default by all libraries in this toolkit. The implementation differs from the Kiota implementation:

- Include a retry policy (default is 3 retries)
- Include automatic decompression
- Throw exceptions on non-successful status codes (above 299)
