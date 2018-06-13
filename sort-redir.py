# Python 3 script to sort .openpublishing.redirection.json by any of the fields
# Requires a Python 3 installation on your computer, see https://www.python.org/downloads
#
# Usage:
#    python sort-redir.py <options>
#
# Options:
#    -i <inputfile> specifies the input file; default is .openpublishing.redirection.json
#    -o <outputfile> specifies the output file: default is .openpublishing.redirection.sorted.json
#    -s <sortfield> specifies the name of the field to sort by; default is source_path. Can also use redirect_url

import sys
import getopt
import json

def main(argv):
    # Arg defaults
    in_file = '.openpublishing.redirection.json'
    out_file = '.openpublishing.redirection.sorted.json'
    sort_field = 'source_path'
    usage_string = 'python sort-redir.py [-i <inputfile>] [-o <outputfile>] [-s <sortfield>] [-h] [-?]'

    # Process arguments if provided
    try:
        opts, args = getopt.getopt(argv, "i:o:s:h?") #, ["inputfile=", "outputfile=", "sortfield="]
    except getopt.GetoptError:
        print(usage_string)
        sys.exit(2)
    
    for opt, arg in opts:
        if opt == '-h' or opt == '-?':
            print(usage_string)
            sys.exit()
        elif opt in ("-i", "--inputfile"):
            in_file = arg
        elif opt in ("-o", "--outputfile"):
            out_file = arg
        elif opt in ("-s", "--sortfield"):
            sort_field = arg

    print('Sorting', in_file, 'by', sort_field, 'into', out_file)
    
    with open(in_file) as file:
        data = json.load(file)
        
        # The redirections object within the json
        redirects = data['redirections']

        # Do the sorting and stuff the array back into the original json object
        data_sorted = sorted(redirects, key = lambda redirect: redirect[sort_field])
        data['redirections'] = data_sorted

        with open(out_file, 'w') as outfile:
            json.dump(data, outfile, indent=4)
     

if __name__ == "__main__":
    # Give main all args except the .py filename
    main(sys.argv[1:])