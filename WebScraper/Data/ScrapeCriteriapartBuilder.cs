using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WebScraper.Data
{
    public class ScrapeCriteriapartBuilder
    {



        private string _regex;
        private RegexOptions _regexOptions;


        public ScrapeCriteriapartBuilder()
        {
            SetDefaults();
        }

        private void SetDefaults()
        {
            _regex = string.Empty;
            _regexOptions = RegexOptions.None;

        }

        public ScrapeCriteriapartBuilder withRegex(string regex)
        {
            _regex = regex;
            return this;
        }
        public ScrapeCriteriapartBuilder withRegexOptions(RegexOptions regexOptions)
        {
            _regexOptions = regexOptions;
            return this;
        }

        public ScrapeCriteria Build()
        {
            ScrapeCriteria criteria = new ScrapeCriteria();
            criteria.Regex = _regex;
            criteria.regexOptions = _regexOptions;
            return criteria;

        }


    }
}
