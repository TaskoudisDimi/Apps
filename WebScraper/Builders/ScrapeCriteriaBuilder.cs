using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WebScraper.Data;

namespace WebScraper.Builders
{
    public class ScrapeCriteriaBuilder
    {

        private string _data;
        private string _regex;
        private RegexOptions _regexOptions;
        private List<ScrapeCriteriaPart> _parts;

        public ScrapeCriteriaBuilder()
        {
            SetDefaults();
        }

        private void SetDefaults()
        {
            _data = string.Empty;
            _regex = string.Empty;
            _regexOptions = RegexOptions.None;
            _parts = new List<ScrapeCriteriaPart>();

        }


        public ScrapeCriteriaBuilder withData(string data)
        {
            _data = data;
            return this;
        }
        public ScrapeCriteriaBuilder withRegex(string regex)
        {
            _regex = regex;
            return this;
        }
        public ScrapeCriteriaBuilder withRegexOptions(RegexOptions regexOptions)
        {
            _regexOptions = regexOptions;
            return this;
        }
        public ScrapeCriteriaBuilder withparts(ScrapeCriteriaPart parts)
        {
            _parts.Add(parts);
            return this;
        }

        public ScrapeCriteria Build()
        {
            ScrapeCriteria criteria = new ScrapeCriteria();
            criteria.Data = _data;
            criteria.Regex = _regex;
            criteria.regexOptions = _regexOptions;
            criteria.parts = _parts;
            return criteria;

        }

    }
}
