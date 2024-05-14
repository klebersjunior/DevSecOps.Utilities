using System;
using System.Net.Http.Headers;
using System.Text;

namespace DevSecOps.Utilities.WebApi.Service
{
    public class HttpService
    {
        public HttpService()
        {
        }

        public async Task<string> GetApiAsync(string requestUrl, Dictionary<string, string> parameters, Dictionary<string, string> headers = null)
        {
            var result = "";
            var requestUriStr = requestUrl;
            if (parameters.Count > 0)
                requestUriStr =requestUrl + "?";

            foreach (var item in parameters)
            {
                requestUriStr += string.Format("&{0}={1}", item.Key, item.Value);
            }

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(requestUriStr);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.Timeout = new TimeSpan(0, 1, 0);

                    if (headers != null)
                    {
                        foreach (var item in headers)
                        {
                            client.DefaultRequestHeaders.Add(item.Key, item.Value);
                        }
                    }

                    try
                    {
                        using (HttpResponseMessage response = await client.GetAsync(requestUriStr))
                        {
                            if (response.IsSuccessStatusCode)
                            {
                                using (HttpContent content = response.Content)
                                {
                                    result = await content.ReadAsStringAsync();
                                }
                            }
                            else
                            {
                                throw new Exception($"{response.StatusCode.ToString()} - {response.Content.ReadAsStringAsync().Result}");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }


        public async Task<string> GetApiAsync(string baseurl, string arg)
        {
            var result = "";

            var _argument = arg;

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    if (!string.IsNullOrEmpty(arg))
                        client.BaseAddress = new Uri($"{baseurl}?{arg}");
                    else
                        client.BaseAddress = new Uri($"{baseurl}");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.Timeout = new TimeSpan(0, 1, 0);

                    try
                    {
                        using (HttpResponseMessage response = await client.GetAsync(_argument))
                        {
                            if (response.IsSuccessStatusCode)
                            {
                                using (HttpContent content = response.Content)
                                {
                                    result = await content.ReadAsStringAsync();
                                }
                            }
                            else
                            {
                                throw new Exception($"{response.StatusCode.ToString()} - {response.Content.ReadAsStringAsync().Result}");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public async Task<string> DeleteApiAsync(string baseurl, string arg, Dictionary<string, string> parameters, Dictionary<string, string> headers = null)
        {
            var result = "";
            var _urlapisf = baseurl;
            var _argument = arg;

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    if (!string.IsNullOrEmpty(arg))
                        client.BaseAddress = new Uri($"{_urlapisf}?{arg}");
                    else
                        client.BaseAddress = new Uri($"{_urlapisf}");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    if (headers != null)
                    {
                        foreach (var item in headers)
                        {
                            client.DefaultRequestHeaders.Add(item.Key, item.Value);
                        }
                    }

                    try
                    {
                        using (HttpResponseMessage response = await client.DeleteAsync(_argument))
                        {
                            if (response.IsSuccessStatusCode)
                            {
                                using (HttpContent content = response.Content)
                                {
                                    result = await content.ReadAsStringAsync();
                                }
                            }
                            else
                            {
                                throw new Exception(response.StatusCode.ToString());
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public async Task<string> PutApiAsync(string baseurl, string body, string arg)
        {
            var result = "";
            var _urlapisf = baseurl;
            var _argument = arg;
            var _body = body;

            var _bodyContent = new StringContent(_body, Encoding.UTF8, "application/json");

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    if (!string.IsNullOrEmpty(arg))
                        client.BaseAddress = new Uri($"{_urlapisf}?{arg}");
                    else
                        client.BaseAddress = new Uri($"{_urlapisf}");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json; charset=utf-8");
                    try
                    {
                        using (HttpResponseMessage response = await client.PutAsync(_argument, _bodyContent))
                        {
                            if (response.IsSuccessStatusCode)
                            {
                                using (HttpContent content = response.Content)
                                {
                                    result = await content.ReadAsStringAsync();
                                }
                            }
                            else
                            {
                                using (HttpContent content = response.Content)
                                {
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return result;
        }

        public async Task<string> PostApiAsync(string baseurl, string body, string arg = "", Dictionary<string, string> headers = null)
        {
            var result = "";
            var _urlapisf = baseurl;
            var _argument = arg;
            var _bodyContent = new StringContent(body, Encoding.UTF8, "application/json");

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    if (!string.IsNullOrEmpty(arg))
                        client.BaseAddress = new Uri($"{_urlapisf}?{arg}");
                    else
                        client.BaseAddress = new Uri($"{_urlapisf}");

                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");

                    if (headers != null)
                    {
                        foreach (var item in headers)
                        {
                            client.DefaultRequestHeaders.Add(item.Key, item.Value);
                        }
                    }

                    try
                    {
                        using (HttpResponseMessage response = await client.PostAsync($"{_urlapisf}?{arg}", _bodyContent))
                        {
                            if (response.IsSuccessStatusCode)
                            {
                                using (HttpContent content = response.Content)
                                {
                                    result = await content.ReadAsStringAsync();
                                }
                            }
                            else
                            {
                                using (HttpContent content = response.Content)
                                {
                                    result = await content.ReadAsStringAsync();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return result;
        }

        public async Task<string> PutApiAsync(string baseurl, string body, string arg = "", Dictionary<string, string> headers = null)
        {
            var result = "";
            var _urlapisf = baseurl;
            var _argument = arg;
            var _bodyContent = new StringContent(body, Encoding.UTF8, "application/json");

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    if (!string.IsNullOrEmpty(arg))
                        client.BaseAddress = new Uri($"{_urlapisf}?{arg}");
                    else
                        client.BaseAddress = new Uri($"{_urlapisf}");

                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");

                    if (headers != null)
                    {
                        foreach (var item in headers)
                        {
                            client.DefaultRequestHeaders.Add(item.Key, item.Value);
                        }
                    }

                    try
                    {
                        using (HttpResponseMessage response = await client.PutAsync($"{_urlapisf}?{arg}", _bodyContent))
                        {
                            if (response.IsSuccessStatusCode)
                            {
                                using (HttpContent content = response.Content)
                                {
                                    result = await content.ReadAsStringAsync();
                                }
                            }
                            else
                            {
                                using (HttpContent content = response.Content)
                                {
                                    result = await content.ReadAsStringAsync();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return result;
        }
    }
}

